using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Receiver
{
    class ReceiverHelper
    {
        public void ConsoleToCSVformat(String[] data)
        {
            ReaderStruct record = new ReaderStruct();
            for (int i = 0; i <= data.Length; i += 2)
            {
                record.time = data[i];
                record.comment = data[i + 1];
            }
        }
        public void WriteToCSV(ReaderStruct record, string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@path, true))
                {
                    file.WriteLine(record.time + "," + record.comment);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ApplicationException("error", e);

            }
        }

    }
}
