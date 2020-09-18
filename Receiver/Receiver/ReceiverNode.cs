
namespace Receiver
{
    class ReceiverNode
    {

        public static void Main()
        {
            //Console.WriteLine("Enter Filters : 0 to get series of words from complete csv file" +
            //    "  1 to get series of words from Column filter: 1 for Date and time Column and 2 for Comments Column");
            CsvWriteHandler writer = new CsvWriteHandler();
            ReadConsoleHandler reader = new ReadConsoleHandler();
            writer.WriteToCsv(reader.ListToWordCountMap(reader.ReadFromConsole()),writer.FilePathGen("Reader.csv"));
        }
    }
}
