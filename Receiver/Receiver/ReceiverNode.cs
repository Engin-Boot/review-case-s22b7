namespace Receiver
{
    class ReceiverNode
    {

        public static void Main(string[] args)
        {
            CSVwriteHandler writer = new CSVwriteHandler();
            ReadConsoleHandler reader = new ReadConsoleHandler();
            writer
                .WriteToCSV(
                 reader
                 .ListToWordCountMap(
                  reader.ReadFromConsole()),
                  writer.FilePathGen("Reader.csv"));
        }
    }
}
