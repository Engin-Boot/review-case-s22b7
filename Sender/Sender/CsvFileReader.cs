using System;


namespace Sender
{
    public class CsvFileReader
    {
        public static bool ReadCsvFile(string path)
        {
            bool pathExists = PathExistance.CheckPathExistOrNot(path);
            bool val = false;
            if (pathExists)
            {
                Console.WriteLine("Enter 0 to get Series of Words for complete CSV file and Enter 1 for Column filter");
                String userInput = Console.ReadLine();

                if (userInput == "0")
                {
                    SeriesOfWords.ConvertCommentsToSeriesOfWords(path, "0");
                }
                else
                {
                    string columnNumbers = ColumnNumber.TakeColumnNumberForColumnFilter();
                    SeriesOfWords.ConvertCommentsToSeriesOfWords(path, columnNumbers);
                }
                val = true;
            }
            return val;

        }
    }
}
