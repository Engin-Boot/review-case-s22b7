using System;
using System.Linq;
using System.IO;
using System.Threading;

namespace Receiver
{
    class ReceiverNode
    {
        static void Main(string[] args)
        {
            ConsoleToCSVformat(ReadFromConsole());     
        }

        public static string[] ReadFromConsole()
        {
            string ConsoleEntry;
            string[] ConsoleContent = { };
            ConsoleEntry = Console.ReadLine();
            while (!string.IsNullOrEmpty(ConsoleEntry))
            {
                ConsoleContent.Append(ConsoleEntry);
                ConsoleEntry = Console.ReadLine();
            }
            return ConsoleContent;
        }
          public static void ConsoleToCSVformat(String[] data)
        {
            ReaderStruct record = new ReaderStruct();
            for (int i=0; i <= data.Length; i++)
            {
                record.time = data[i];
                record.comment = data[++i];
                WriteToCSV(record);
            }           
        }

        static void WriteToCSV(ReaderStruct record)
        {
            string path = "ReaderCSV.csv";
            try
            {
                using (StreamWriter file = new StreamWriter(@path, true))
                {
                    file.WriteLine(record.time + "," + record.comment);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }


}
