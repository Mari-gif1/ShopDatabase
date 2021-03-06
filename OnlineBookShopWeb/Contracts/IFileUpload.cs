using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShopWeb.Contracts
{
    public interface IFileUpload
    {
        public Task UploadFile(Stream msFile, string picName);
        public void RemoveFile(string picName);
    }
}
