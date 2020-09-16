namespace Receiver
{
    class ReceiverNode
    {
        static void Main()
        {
            CsvWriteHandler
                .WriteToCsv(
                 ReadConsoleHandler
                 .ListToWordCountMap(
                  ReadConsoleHandler.ReadFromConsole()),
                  CsvWriteHandler.FilePathGen("Reader.csv"));
        }
    }
}
