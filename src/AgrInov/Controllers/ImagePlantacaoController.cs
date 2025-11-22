using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.IO;
using AgrInov.Models;
using AgrInov.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Drawing;
namespace AgrInov.Controllers

{
    public class ImagemPlantacaoController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

       public ImagemPlantacaoController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
        
            var imagemPlantacoes = await _context.ImagemPlantacao.ToListAsync();

            var listaViewModel = new List<ImagemPlantacaoViewModel>();

            foreach (var ip in imagemPlantacoes)
            {
                var imagem = await _context.Imagem.FindAsync(ip.ImagemId);
                var plantacao = await _context.Plantacoes.FindAsync(ip.PlantacaoId);

                if (imagem != null && plantacao != null)
                {
                    listaViewModel.Add(new ImagemPlantacaoViewModel
                    {
                        Imagem = imagem,
                        Plantacao = plantacao
                    });
                }
            }

            return View(listaViewModel);
        }

        public async  Task<IActionResult> Create()
        {
            var viewModel = new ImagemPlantacaoViewModel
            {
                Imagem = new Imagem(),
                Plantacao = new Plantacao(),
                ListaPlantacoes = await _context.Plantacoes.ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ImagemPlantacaoViewModel imagemPlantacao)
        {
            if (!ModelState.IsValid)
                return View(imagemPlantacao);
            var imagem = imagemPlantacao.Imagem;

            var extension = Path.GetExtension(imagemPlantacao.Imagem.Image.FileName).ToLowerInvariant();
            if (extension != ".jpg")
            {
                ModelState.AddModelError("ImagePlantacao", "Somente imagens JPG são permitidas.");
                return View(imagemPlantacao);
            }

            if (imagemPlantacao.Imagem.Image != null && imagemPlantacao.Imagem.Image.Length > 0)
            {
            
                using var memoryStream = new MemoryStream();
                await imagemPlantacao.Imagem.Image.CopyToAsync(memoryStream);
                memoryStream.Position = 0;

                
                var (lat, lon, takenAt) = ExifReader.GetExifData(memoryStream);

                if (lat.HasValue) imagemPlantacao.Imagem.Latitude = lat.Value;
                if (lon.HasValue) imagemPlantacao.Imagem.Longitude = lon.Value;
                if (takenAt.HasValue) imagemPlantacao.Imagem.DataCriacao = takenAt.Value;

                memoryStream.Position = 0;

                
                string connectionString = _configuration["AzureStorage:ConnectionString"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
                string containerName = _configuration["AzureStorage:ContainerName"] ?? Environment.GetEnvironmentVariable("AZURE_CONTAINER_NAME");

                var blobContainerClient = new BlobContainerClient(connectionString, containerName);
                await blobContainerClient.CreateIfNotExistsAsync();

                string fileName = Guid.NewGuid().ToString();
                string fileNameWithExtension = fileName + extension;
                var blobClient = blobContainerClient.GetBlobClient(fileNameWithExtension);

                await blobClient.UploadAsync(memoryStream, overwrite: true);

                imagemPlantacao.Imagem.ImageUrl = fileName;
            }
            _context.Imagem.Add(imagem);
            await _context.SaveChangesAsync(); 

            var mapping = new ImagemPlantacao
            {
                PlantacaoId = imagemPlantacao.Plantacao.Id,
                ImagemId = imagem.Id
            };
            
            _context.ImagemPlantacao.Add(mapping);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var imagem = await _context.Imagem
            .FirstOrDefaultAsync(i => i.Id == id);

            var imagemPlantacao = await _context.ImagemPlantacao
                .FirstOrDefaultAsync(p => p.ImagemId == imagem.Id);

            var plantacao = await _context.Plantacoes.FirstOrDefaultAsync(i => i.Id==imagemPlantacao.PlantacaoId);

            if (imagem == null || imagemPlantacao == null)
                return NotFound();

            var vm = new ImagemPlantacaoViewModel
            {
                Imagem = imagem,
                Plantacao = plantacao
            };

            return View(vm);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagem.FindAsync(id);

            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {

            if (id == null)
                return NotFound();

            var imagem = await _context.Imagem.FindAsync(id);
            var imagePlantacao = await  _context.ImagemPlantacao.FirstOrDefaultAsync(i => i.ImagemId==imagem.Id);
            if (imagem != null)
            {
                _context.Imagem.Remove(imagem);
            }

            try
            {
             
                string connectionString = _configuration["AzureStorage:ConnectionString"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
                string containerName = _configuration["AzureStorage:ContainerName"] ?? Environment.GetEnvironmentVariable("AZURE_CONTAINER_NAME");

              
                var blobContainerClient = new BlobContainerClient(connectionString, containerName);
                await blobContainerClient.CreateIfNotExistsAsync();

      
                string blobName;
                if (imagem.ImageUrl.StartsWith("http"))
                {
                    
                    blobName = Path.GetFileName(new Uri(imagem.ImageUrl).AbsolutePath);
                }
                else
                {
                
                    blobName = imagem.ImageUrl;
                }

       
                var blobClient = blobContainerClient.GetBlobClient(blobName+".jpg");
                await blobClient.DeleteIfExistsAsync();

                
                _context.ImagemPlantacao.Remove(imagePlantacao);
                await _context.SaveChangesAsync();

                _context.Imagem.Remove(imagem);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Imagem removida com sucesso.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Erro ao excluir imagem: {ex.Message}";
            }

            return RedirectToAction(nameof(Index));
        }

    }

}
