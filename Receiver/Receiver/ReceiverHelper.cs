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
  
        }
        public void WriteToCSV(ReaderMap record, string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@path, true))
                {
                   // file.WriteLine(record.time + "," + record.comment);
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
