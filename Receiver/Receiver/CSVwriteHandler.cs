using System;
using System.Collections.Generic;
using System.IO;

namespace Receiver
{
    public class CSVwriteHandler
    {
        public void WriteToCSV(Dictionary<String, int> record, string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@path, false))
                {
                    foreach (var item in record)
                        file.WriteLine(item.Key + "," + item.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ApplicationException("error", e);

            }
        }
        public string FilePathGen(string writeFile)
        {
            string file = Path.Combine(Directory.GetCurrentDirectory(), writeFile);
            if (File.Exists(file))
                File.Delete(file);
            File
                .Create(file)
                .Close();
            Console.WriteLine("New file created successfully...");
            return file;
        }
    }
}
