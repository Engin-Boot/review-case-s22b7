using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Receiver
{
    class FileHandler
    {
        public static string FilePathGen(string readerfile)
        {
            string file = Path.Combine(Directory.GetCurrentDirectory(), readerfile);
            if (File.Exists(file))
                File.Delete(file);
            File
                .Create(file)
                .Close();
            Console.WriteLine("New file created...");
            return file;
        }
    }
}
