

namespace Sender
{
    class Sender
    {
        static void Main()
        {
            //Console.WriteLine("Enter File path");
            //string path = Console.ReadLine();
            string path = "C:/Users/HP/Desktop/Git_CaseStudy_Final/review-case-s22b7/sample-review/review-report.csv";
            CsvFileReader.ReadCsvFile(path);           
        }
    }
}

