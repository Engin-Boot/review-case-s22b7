using System;


namespace Sender
{
    public class SeriesOfWords
    {
        public static string[] ConvertCommentsToSeriesOfWords(string path, string columnNumbers)
        {

            int columnnumber = Convert.ToInt32(columnNumbers);
            string[] lines = System.IO.File.ReadAllLines(path);
            LineLoop.ApplyLineLoop(lines, columnnumber);
            return lines;//Test
        }
    }

    public class LineLoop
    {
        public static string ApplyLineLoop(string[] lines, int columnnumber)
        {
            for (int lineNumber = 1; lineNumber < lines.Length; lineNumber++)
            {
                string line = lines[lineNumber];
                string[] columns = line.Split(',');
                int columnsCount = columns.Length;

                int[] startStopColumnNumber = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(columnnumber, columnsCount);
                int startColumnNumber = startStopColumnNumber[0];
                int stopColumnNumber = startStopColumnNumber[1];
                ColumnFilter.ApplyColumnFilter(line, startColumnNumber, stopColumnNumber);
            }
            string line1 = lines[0];//Test
            return line1;
        }
    }
}
