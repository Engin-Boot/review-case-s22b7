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

                string[] words = reviewComment.Split(' ');

                foreach (var word in words)
                {
                    System.Console.WriteLine(word);
                }
            }
        }
    }
}

