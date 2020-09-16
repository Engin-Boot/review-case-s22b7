using System;

namespace Sender
{
    public class SeriesOfWords
    {
        public static void ConvertCommentsToSeriesOfWords(string path, string Column_Number)
        {
            LineLoop
                .ApplyLineLoop(
                 System.IO.File.ReadAllLines(path),
                 Convert.ToInt32(Column_Number));
        }
    }

    class LineLoop
    {
        public static void ApplyLineLoop(string[] lines, int column_number)
        {
            int StartColumnNumber, StopColumnNumber;
            foreach (string line in lines)
            {
                StartStopColumnNumbers
                    .ReturnStartAndStopColumnNumbers(column_number, (line.Split(',')).Length,
                        out StartColumnNumber, out StopColumnNumber);
                Column_Filter
                    .ApplyColumnFilter(line, StartColumnNumber, StopColumnNumber);
            }
        }


        }
}
