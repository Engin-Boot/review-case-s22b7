using System;
using System.IO;

namespace Sender
{
    public class PathExistance
    {
        public static bool CheckPathExistOrNot(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }
}
