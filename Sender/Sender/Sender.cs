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
            string path = "C:/Users/HP/Desktop/CaseStudy_Review/review-case-s22b7/sample-review/review-report.csv";
            if (File.Exists(path))
            {
                //Console.WriteLine("Specified file exists.");
                Console.WriteLine("Enter Line Number to get word series of perticular line and enter 0 to get word series of complete csv file");
                String LineNumber = Console.ReadLine();
                SeriesOfWords.ConvertCommentsToSeriesOfWords(path, LineNumber);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
    class SeriesOfWords
    {
        public static void ConvertCommentsToSeriesOfWords(string path, string user_input)
        {
            int userinput = Convert.ToInt32(user_input);
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

                for (int columnNumber = 0; columnNumber < columns.Length; columnNumber++)
                {
                    string reviewComment = columns[columnNumber];
                    //Console.WriteLine(reviewComment);

                    string[] words = reviewComment.Split(' ');
                    foreach (var word in words)
                    {
                        //System.Console.Write(word+"  ");
                        System.Console.WriteLine(word);
                    }
                    Console.WriteLine();

                }
            }

        }
    }
}

