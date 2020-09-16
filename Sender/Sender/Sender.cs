using System;

namespace Sender
{
    class Sender
    {
        static void Main()
        {
            Console.WriteLine("Enter File Path");
            CsvFileReader.ReadCsvFile(Console.ReadLine());
        }
    }
}

