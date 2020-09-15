using System;
using System.IO;

namespace Sender
{
    public class CsvFileReader
    {
        public static void ReadCsvFile(string path)
        {
            bool pathExists = PathExistance.CheckPathExistOrNot(path);
            if (pathExists == true)
            {
                Console.WriteLine("Enter 0 to get Series of Words for complete CSV file and Enter 1 for Column filter");
                String UserInput = Console.ReadLine();
                if (UserInput == "0")
                {
                    SeriesOfWords.ConvertCommentsToSeriesOfWords(path, "0");
                }
                else
                {
                    string ColumnNumber = Column_Number.TakeColumnNumberForColumnFilter(UserInput);
                    SeriesOfWords.ConvertCommentsToSeriesOfWords(path, ColumnNumber);
                }
            }

        }
    }
}
