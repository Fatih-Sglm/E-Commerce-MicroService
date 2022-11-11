using E_Commerce.CatalogService.Application.Abstractions.Storage.Local;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Infrastructure.Services.Storage.Local
{
    public class LocalStorage : ILocalStorage
    {
        private readonly string WebRootPath;

        public LocalStorage(IWebHostEnvironment _env)
        {
            WebRootPath = _env.WebRootPath;
        }

        public Task DeleteAsync(string path, string fileName)
        {
            File.Delete(PathCombine(path, fileName));
            return Task.CompletedTask;
        }

        public string? GetFile(string path, string filename)
        {
            DirectoryInfo df = new(PathCombine(path));
            return df.GetFiles()?.FirstOrDefault(x => x.Name == filename).FullName;
        }

        public bool HasFile(string path, string fileName)
         => File.Exists(PathCombine(path, fileName));

        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = PathCombine(path);
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);
            List<(string fileName, string path)> datas = new();
            foreach (IFormFile file in files)
            {
                //string fileNewName = await FileRenameAsync(path, file.Name, HasFile);

                await CopyFileAsync($"{uploadPath}\\{file.FileName}", file);
                datas.Add((file.FileName, path));
            }

            return datas;
        }

        private async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);

                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                //todo log!
                throw new Exception(ex.ToString());
            }
        }

        private string PathCombine(string path, string filename = null)
        {
            if (filename is null)
                return Path.Combine(WebRootPath, path);
            return Path.Combine(WebRootPath, path, filename);
        }
    }
}
