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
namespace AgrInov.Controllers

{
    public class ImagemController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

       public ImagemController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()

        {
            return View(await _context.Imagem.ToListAsync());
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Imagem imagem)
        {
            if (!ModelState.IsValid)
                return View(imagem);

            if (imagem.Image != null && imagem.Image.Length > 0)
            {
            
                using var memoryStream = new MemoryStream();
                await imagem.Image.CopyToAsync(memoryStream);
                memoryStream.Position = 0;

                
                var (lat, lon, takenAt) = ExifReader.GetExifData(memoryStream);

                if (lat.HasValue) imagem.Latitude = lat.Value;
                if (lon.HasValue) imagem.Longitude = lon.Value;
                if (takenAt.HasValue) imagem.DataCriacao = takenAt.Value;

                memoryStream.Position = 0;

                
                string connectionString = _configuration["AzureStorage:ConnectionString"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");
                string containerName = _configuration["AzureStorage:ContainerName"] ?? Environment.GetEnvironmentVariable("AZURE_CONNECTION_STRING");

                var blobContainerClient = new BlobContainerClient(connectionString, containerName);
                await blobContainerClient.CreateIfNotExistsAsync();

                string fileName = Guid.NewGuid().ToString();
                string fileNameWithExtension = fileName + Path.GetExtension(imagem.Image.FileName).ToLower();
                var blobClient = blobContainerClient.GetBlobClient(fileNameWithExtension);

                await blobClient.UploadAsync(memoryStream, overwrite: true);

                imagem.ImageUrl = fileName;
            }

            _context.Imagem.Add(imagem);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return null;

            var imagem = await _context.Imagem.FindAsync(id);

            if (imagem == null)
                return null;
            return View(imagem);
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
            if (imagem != null)
            {
                _context.Imagem.Remove(imagem);
            }

            try
            {
             
                string connectionString = _configuration["AzureStorage:ConnectionString"];
                string containerName = _configuration["AzureStorage:ContainerName"];

              
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
