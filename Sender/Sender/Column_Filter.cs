using System;
using System.Linq;

namespace Sender
{
    public class Column_Filter
    {
        public static void ApplyColumnFilter(string line, int startcolumn, int stopcolumn)
        {
            string[] ColumnElements = BreakLineToItems(line, ',');
            for (int columnNumber = startcolumn; columnNumber < stopcolumn; columnNumber++)
            {
                // Break CSV to Columns,select each column, then Break line to words
                
                string[] words = BreakLineToItems(
                                    ColumnElements[columnNumber], ' ');
                for (int i =0; i < words.Length; i++)
                    Console.WriteLine(words[i]);
            }
        }
        public static string[] BreakLineToItems(string line, char split)
        {
            return line.Split(split);
        }
    }
}

