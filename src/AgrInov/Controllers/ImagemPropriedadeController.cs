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
    public class ImagemPropriedadeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

       public ImagemPropriedadeController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
        
            var imagemPropriedade = await _context.ImagemPropriedade.ToListAsync();

            var listaViewModel = new List<ImagemPropriedadeViewModel>();

            foreach (var ip in imagemPropriedade)
            {
                var imagem = await _context.Imagem.FindAsync(ip.ImagemId);
                var Propriedade = await _context.PropriedadeAgricula.FindAsync(ip.PropriedadeAgriculaId);

                if (imagem != null && Propriedade != null)
                {
                    listaViewModel.Add(new ImagemPropriedadeViewModel
                    {
                        Imagem = imagem,
                        PropriedadeAgricula = Propriedade
                    });
                }
            }

            return View(listaViewModel);
        }

        public async  Task<IActionResult> Create()
        {

            
            var viewModel = new ImagemPropriedadeViewModel
            {
                Imagem = new Imagem(),
                PropriedadeAgricula = new PropriedadeAgricula(),
                ListPropriedadeAgricula = await _context.PropriedadeAgricula.ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ImagemPropriedadeViewModel ImagemPropriedade)
        {
            
            var imagem = ImagemPropriedade.Imagem;
            var extension = Path.GetExtension(ImagemPropriedade.Imagem.Image.FileName).ToLowerInvariant();
            if (extension != ".jpg")
            {
                ModelState.AddModelError("ImagePropriedade", "Somente imagens JPG são permitidas.");
                return View(ImagemPropriedade);
            }

            if (ImagemPropriedade.Imagem.Image != null && ImagemPropriedade.Imagem.Image.Length > 0)
            {
            
                using var memoryStream = new MemoryStream();
                await ImagemPropriedade.Imagem.Image.CopyToAsync(memoryStream);
                memoryStream.Position = 0;

                
                var (lat, lon, takenAt) = ExifReader.GetExifData(memoryStream);

                if (lat.HasValue) ImagemPropriedade.Imagem.Latitude = lat.Value;
                if (lon.HasValue) ImagemPropriedade.Imagem.Longitude = lon.Value;
                if (takenAt.HasValue) ImagemPropriedade.Imagem.DataCriacao = takenAt.Value;

                memoryStream.Position = 0;

                
                string connectionString = _configuration["AzureStorage:ConnectionString"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
                string containerName = _configuration["AzureStorage:ContainerNamePropriedade"] ?? Environment.GetEnvironmentVariable("AZURE_CONTAINER_NAME_PROPRIEDADE");

                var blobContainerClient = new BlobContainerClient(connectionString, containerName);
                await blobContainerClient.CreateIfNotExistsAsync();

                string fileName = Guid.NewGuid().ToString();
                string fileNameWithExtension = fileName + extension;
                var blobClient = blobContainerClient.GetBlobClient(fileNameWithExtension);

                await blobClient.UploadAsync(memoryStream, overwrite: true);

                ImagemPropriedade.Imagem.ImageUrl = fileName;
            }
            _context.Imagem.Add(imagem);
            await _context.SaveChangesAsync(); 

            var mapping = new ImagemPropriedade
            {
                PropriedadeAgriculaId = ImagemPropriedade.PropriedadeAgricula.Id,
                ImagemId = imagem.Id
            };
            
            _context.ImagemPropriedade.Add(mapping);
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

            var ImagemPropriedade = await _context.ImagemPropriedade
                .FirstOrDefaultAsync(p => p.ImagemId == imagem.Id);

            var Propriedade = await _context.PropriedadeAgricula.FirstOrDefaultAsync(i => i.Id==ImagemPropriedade.PropriedadeAgriculaId);

            if (imagem == null || ImagemPropriedade == null)
                return NotFound();

            var vm = new ImagemPropriedadeViewModel
            {
                Imagem = imagem,
                PropriedadeAgricula = Propriedade
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
            var imagePropriedade = await  _context.ImagemPropriedade.FirstOrDefaultAsync(i => i.ImagemId==imagem.Id);
            if (imagem != null)
            {
                _context.Imagem.Remove(imagem);
            }

            try
            {
             
                string connectionString = _configuration["AzureStorage:ConnectionString"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
                string containerName = _configuration["AzureStorage:ContainerNamePropriedade"] ?? Environment.GetEnvironmentVariable("AZURE_CONTAINER_NAME_PROPRIEDADE");

              
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

                
                _context.ImagemPropriedade.Remove(imagePropriedade);
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
