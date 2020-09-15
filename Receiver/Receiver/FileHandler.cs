using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Receiver
{
    class FileHandler
    {
        public static string FilePathGen(string fileName)
        {
            string file = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (File.Exists(file))
                File.Delete(file);
            File
                .Create(file)
                .Close();
            return file;
        }
    }
}
