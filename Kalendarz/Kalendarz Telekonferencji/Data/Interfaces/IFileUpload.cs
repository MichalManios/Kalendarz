using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Data.Interfaces
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry fileListEntry);
        Task SendToServerAsync();
        Task ChoiceFileToUpload(IFileListEntry[] files);
        Task<bool> UploadFileAsync();
        string GetMessage();
        string GetURLToFile();
        public bool IsAnyFileWaitToUpload();

    }
}
