namespace Receiver
{
    class ReceiverNode
    {

        public static void Main(string[] args)
        {
            CsvWriteHandler writer = new CsvWriteHandler();
            ReadConsoleHandler reader = new ReadConsoleHandler();
            writer
                .WriteToCsv(
                 reader
                 .ListToWordCountMap(
                  reader.ReadFromConsole()),
                  writer.FilePathGen("Reader.csv"));
        }
    }
}
