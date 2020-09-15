using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class Column_Filter
    {
        public static void ApplyColumnFilter(string line, int startcolumn, int stopcolumn)
        {
            string[] columns = line.Split(',');
            for (int columnNumber = startcolumn; columnNumber < stopcolumn; columnNumber++)
            {
                string reviewComment = columns[columnNumber];

                string[] words = ConvertLineToSeriesOfWords.ConvertLine_ToSeriesOfWords(reviewComment);

                foreach (var word in words)
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }

    public class ConvertLineToSeriesOfWords
    {
        public static string[] ConvertLine_ToSeriesOfWords(string reviewComment)
        {
            string[] words = reviewComment.Split(' ');
            return words;
        }
    }
}

