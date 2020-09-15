using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class StartStopColumnNumbers
    {
        public static int[] ReturnStartAndStopColumnNumbers(int ColumnNumber, int ColumnCount)
        {
            int[] start_stopColumnNumber = new int[2];
            if (ColumnNumber == 0)
            {
                start_stopColumnNumber[0] = 0;
                start_stopColumnNumber[1] = ColumnCount;
                return start_stopColumnNumber;
            }
            else if (ColumnNumber == 1)
            {
                start_stopColumnNumber[0] = 0;
                start_stopColumnNumber[1] = 1;
                return start_stopColumnNumber;
            }
            else
            {
                start_stopColumnNumber[0] = 1;
                start_stopColumnNumber[1] = ColumnCount;
                return start_stopColumnNumber;
            }
        }
    }
}
