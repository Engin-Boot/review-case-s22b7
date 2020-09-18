using System.Configuration;

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
                  ReadConsoleHandler.RemoveStopWords(
                  ReadConsoleHandler.ReadFromConsole())),
                  CsvWriteHandler.FilePathGen(ConfigurationManager.AppSettings.Get("fileName")));
        }
    }
}
