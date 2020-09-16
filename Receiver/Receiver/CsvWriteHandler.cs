using System;
using System.Collections.Generic;
using System.IO;

namespace Receiver
{
    public class CsvWriteHandler
    {
        public static void WriteToCsv(Dictionary<String, int> record, string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path, false))
                {
                    foreach (var item in record)
                        file.WriteLine(item.Key + "," + item.Value);
                }
            }
            catch (Exception e)
            {
                ExceptionHandler(e);
            }
        }
        public static string FilePathGen(string writeFile)
        {
            string file = Path.Combine(Directory.GetCurrentDirectory(), writeFile);
            try
            {
                File
                  .Create(file)
                  .Close();
                Console.WriteLine("New file created successfully...");
            }
            catch (Exception e)
            {
                ExceptionHandler(e);
            }
            return file;
        }

        private static void ExceptionHandler(Exception e)
        {
            Console.WriteLine(e.Message);
            throw new ApplicationException("error", e);
        }
    }
}
