
namespace Sender
{
    public class ColumnFilter
    {
        public static string[] ApplyColumnFilter(string line, int startcolumn, int stopcolumn)
        {
            string[] columns = line.Split(',');
            for (int columnNumber = startcolumn; columnNumber < stopcolumn; columnNumber++)
            {
                string reviewComment = columns[columnNumber];

                string[] words = ConvertLineToTheSeriesOfWords.ConvertLineToSeriesOfWords(reviewComment);
                foreach (var word in words)
                {
                    System.Console.WriteLine(word);

                }

            }
            return columns;//Test

        }
    }

    public class ConvertLineToTheSeriesOfWords
    {
        public static string[] ConvertLineToSeriesOfWords(string reviewComment)
        {
            string[] words = reviewComment.Split(' ');
            return words;
        }
    }
}

