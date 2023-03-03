namespace LibraryApp.SupportClasses.FileConverter
{
    public static class FileConverter
    {
        public static async Task<byte[]> FormFileToBytes(IFormFile formFile)
        {
            await using var memoryStream = new MemoryStream();
            await formFile.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
