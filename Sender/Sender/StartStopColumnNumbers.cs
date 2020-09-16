namespace Sender
{
    public class StartStopColumnNumbers
    {
        public static void ReturnStartAndStopColumnNumbers(int ColumnNumber, int ColumnCount, out int StartNum , out int StopNum)
        {
            if (ColumnNumber == 0)
            {
                StartNum = 0;
                StopNum = ColumnCount;
                
            }
            else if (ColumnNumber == 1)
            {
                StartNum = 0;
                StopNum = 1;
            }
            else
            {
                StartNum = 1;
                StopNum = ColumnCount;
            }
        }
    }
}
