﻿using System.IO;
using System.Threading.Tasks;

namespace eShopSolution.Application.Common
{
    public interface IStorageService
    {
        string GetFile(string fileName);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}