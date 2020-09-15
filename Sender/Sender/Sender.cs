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
            string path = "C:/Users/HP/Desktop/CaseStudyFinal/review-case-s22b7/sample-review/review-report.csv";
            CsvFileReader.ReadCsvFile(path);           
        }
    }
}

