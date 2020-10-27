using System;

namespace kata_data_munging
{
    public class FileHandler
    {
        public FileCargo read(string path)
        {
            var fileInput = System.IO.File.ReadAllText(path);

            return new FileCargo(fileInput);
        }
    }
}