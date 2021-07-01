using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services
{
    public static class ImageService
    {
        public static async Task<string> UploadImage(IFormFile formFile, string path, IHostingEnvironment _appEnvironment)
        {
            if (formFile != null)
            {
                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(formFile.Name) + ".jpeg";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(_appEnvironment.WebRootPath + path);
                }

                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path + fileName, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }

                return fileName;
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteImage(string pictureName, string path, IHostingEnvironment _appEnvironment)
        {
            string p = _appEnvironment.WebRootPath + path + pictureName;

            if (!File.Exists(p)) return false;

            try
            {
                File.Delete(p);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
