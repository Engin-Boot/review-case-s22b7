using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.IO;

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
