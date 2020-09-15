using System;
using System.IO;

namespace Sender
{
    class Sender
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter File path");
            //string path = Console.ReadLine();
            string path = "C:/Users/HP/Desktop/CaseStudyFinal/review-case-s22b7/sample-review/review-report.csv";
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

    class Column_Number
    {
        public static string TakeColumnNumberForColumnFilter(string UserInput)
        {
            Console.WriteLine("Enter 1 for Date & Time column filter and 2 for Comments Column filter");
            String ColumnNumber = Console.ReadLine();
            return ColumnNumber;
        }

    }

    class SeriesOfWords
    {
        public static void ConvertCommentsToSeriesOfWords(string path, string Column_Number)
        {
            int column_number = Convert.ToInt32(Column_Number);
            string[] lines = System.IO.File.ReadAllLines(path);

            for (int lineNumber = 1; lineNumber < lines.Length; lineNumber++)
            {
                string line = lines[lineNumber];
                string[] columns = line.Split(',');
                int columnsCount = columns.Length;
                int[] Start_StopColumnNumber = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(column_number, columnsCount);
                int StartColumnNumber = Start_StopColumnNumber[0];
                int StopColumnNumber = Start_StopColumnNumber[1];
                Column_Filter.ApplyColumnFilter(line, StartColumnNumber, StopColumnNumber);
            }
        }
    }

    class StartStopColumnNumbers
    {
        public static int[] ReturnStartAndStopColumnNumbers(int ColumnNumber, int ColumnCount)
        {
            int[] start_stopColumnNumber = new int[2];
            if (ColumnNumber == 0)
            {
                start_stopColumnNumber[0] = 0;
                start_stopColumnNumber[1] = ColumnCount;
                return start_stopColumnNumber;
            }
            else if (ColumnNumber == 1)
            {
                start_stopColumnNumber[0] = 0;
                start_stopColumnNumber[1] = 1;
                return start_stopColumnNumber;
            }
            else
            {
                start_stopColumnNumber[0] = 1;
                start_stopColumnNumber[1] = ColumnCount;
                return start_stopColumnNumber;
            }
        }
    }

    class Column_Filter
    {
        public static void ApplyColumnFilter(string line, int startcolumn, int stopcolumn)
        {
            string[] columns = line.Split(',');
            for (int columnNumber = startcolumn; columnNumber < stopcolumn; columnNumber++)
            {
                string reviewComment = columns[columnNumber];

                string[] words = reviewComment.Split(' ');

                foreach (var word in words)
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }

    // test path existance
    public class PathExistanceOfCsvFile
    {
        public bool CheckForPathExistOrNot(string path)
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

