using System;
using System.IO;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/HP/Desktop/CommentReviewCaseStudy/review-report.csv";
            Console.WriteLine("Enter Line Number to get word series of perticular line and enter 0 to get word series of complete csv file");
            int LineNumber = Convert.ToInt32(Console.ReadLine());
            SeriesOfWords.ConvertCommentsToSeriesOfWords(path, LineNumber);
        }
    }
    class SeriesOfWords
    {
        public static void ConvertCommentsToSeriesOfWords(string path, int userinput)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int startline, stopline;
            if (userinput != 0)
            {
                startline = userinput;
                stopline = userinput + 1;
            }
            else
            {
                startline = 1;
                stopline = lines.Length;

            }
            for (int lineNumber = startline; lineNumber < stopline; lineNumber++)
            {
                string line = lines[lineNumber];
                string[] columns = line.Split(',');

                for (int columnNumber = 1; columnNumber < columns.Length; columnNumber++)
                {
                    string reviewComment = columns[columnNumber];
                    //Console.WriteLine(reviewComment);

                    string[] words = reviewComment.Split(' ');
                    foreach (var word in words)
                    {
                        //System.Console.Write(word+"  ");
                        System.Console.WriteLine(word);
                        
                    }

                }
            }

        }
    }
}

