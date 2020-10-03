using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
using Microsoft.Extensions.Configuration;
using PhotoSauce.MagicScaler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Data.FileManager
{

    public interface IFileManager
    {
        FileStream ImageStream(string image);
        Task<string> SaveImage(IFormFile image);
        bool RemoveImage(string image);
    }
    public class FileManager : IFileManager
    {
        private string _ImaghePath;

        public FileManager(IConfiguration configuration)
        {

            _ImaghePath = configuration["Path:Images"];
        }

        public FileStream ImageStream(string image)
        {
            string fileName = Path.Combine(_ImaghePath, image);

            if (File.Exists(fileName))
                return new FileStream(Path.Combine(_ImaghePath, image), FileMode.Open, FileAccess.Read);


            return null;
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            var save_path = Path.Combine(_ImaghePath);

            try
            {
                if (!Directory.Exists(save_path))
                {
                    Directory.CreateDirectory(save_path);
                }

                var mimeType = image.FileName.Substring(image.FileName.LastIndexOf('.'));
                var fileName = $"img_{DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")}{mimeType}";

                using (var fileStram = new FileStream(Path.Combine(save_path, fileName), FileMode.Create))
                {
                   // await image.CopyToAsync(fileStram);
                    MagicImageProcessor.ProcessImage(image.OpenReadStream(), fileStram, ImageOptions());
                }



                return fileName;
            }
            catch (Exception ex)
            {
                //throw ex;
                return "Error";
            }
        }

        public bool RemoveImage(string image)
        {
            if (string.IsNullOrEmpty(image)) return true;

            var file = Path.Combine(_ImaghePath, image);

            try
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                return true;
            }
            catch (Exception e) { return false; }
        }

        private ProcessImageSettings ImageOptions() => new ProcessImageSettings
        {
            Width = 500,
            Height = 500,
            ResizeMode = CropScaleMode.Crop,
            JpegQuality = 100,
            SaveFormat = FileFormat.Jpeg,
            JpegSubsampleMode = ChromaSubsampleMode.Subsample420
        };

    }
}
