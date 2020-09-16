using System;

namespace Sender
{
    public class SeriesOfWords
    {
        public static void ConvertCommentsToSeriesOfWords(string path, string Column_Number)
        {

            int column_number = Convert.ToInt32(Column_Number);
            string[] lines = System.IO.File.ReadAllLines(path);
            LineLoop.ApplyLineLoop(lines, column_number);
        }
    }

    public class LineLoop
    {
        public static void ApplyLineLoop(string[] lines, int column_number)
        {
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
}
