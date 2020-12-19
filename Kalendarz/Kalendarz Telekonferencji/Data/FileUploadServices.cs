using BlazorInputFile;
using Kalendarz_Telekonferencji.Data.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Data
{
    public class FileUploadServices : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private MemoryStream ms;
        private string path;
        IFileListEntry selectedFiles;

        private string sMessage = "";
        private string sURL = "";
        public FileUploadServices(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task UploadAsync(IFileListEntry fileListEntry)
        {
            path = @"C:\inetpub\wwwroot\publish\wwwroot\Documents\" + fileListEntry.Name;
            ms = new MemoryStream();
            await fileListEntry.Data.CopyToAsync(ms);
        }

        public async Task SendToServerAsync()
        {
            using(FileStream file=new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                await Task.Run(()=>ms.WriteTo(file));
            }
        }

        public async Task ChoiceFileToUpload(IFileListEntry[] files)
        {
            selectedFiles = files.FirstOrDefault();
            
                if (selectedFiles != null)
                {
                    await UploadAsync(selectedFiles);

                    sMessage = $"Plik oczekuje na upload: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
                }
            //this.StateHasChanged();
            IsAnyFileWaitToUpload();
        }

        public async Task<bool> UploadFileAsync()
        {
            if (selectedFiles != null)
            {
                sMessage = $"Trwa wrzucanie pliku...";
                await SendToServerAsync();
                sMessage = $"Zakończono ładowanie pliku: {selectedFiles.Name}           Rozmiar: {selectedFiles.Size} Bytes";
                sURL = @"http://localhost:5002/Documents/" + selectedFiles.Name;
                //this.StateHasChanged();
                selectedFiles = null;
                return true;
            }
            else
            {
                sMessage = $"Nie ma wybranego pliku do umieszczenia go na serwerze!!!";
                return false;
            }
        }

        public string GetMessage()
        {
            return sMessage;
        }

        public string GetURLToFile()
        {
            return sURL;
        }

        public bool IsAnyFileWaitToUpload()
        {
            if (selectedFiles != null) return true;
            else return false;
        }
    }
}
