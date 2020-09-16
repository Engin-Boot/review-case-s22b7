using System;
using System.IO;

namespace Sender
{
    public class CsvFileReader
    {
        public static bool ReadCsvFile(string path)
        {
            if (CheckPathExistOrNot(path))
            {
                Console.WriteLine("Enter 0 to get Series of Words for complete CSV file and Enter 1 for Column filter");
                GetUserInputForFilter(path);
                return true;
            }
            else
                return false;
        }

        private static void GetUserInputForFilter(string path)
        {
            string UserInput;
            if ((UserInput = Console.ReadLine()) == "0")
                SeriesOfWords
                    .ConvertCommentsToSeriesOfWords(path, "0");
            else
            {
                SeriesOfWords
                    .ConvertCommentsToSeriesOfWords(path,
                        TakeColumnNumberForColumnFilter());
            }
        }

        private static string TakeColumnNumberForColumnFilter()
        {
            Console.WriteLine("Enter 1 for Date & Time column filter and 2 for Comments Column filter");
            return Console.ReadLine();
        }
        private static bool CheckPathExistOrNot(string path)
        {
            if (File.Exists(path))
                return true;
            else {
                Console.WriteLine("File Not Found");
                return false;
            }
        }
    }
}
