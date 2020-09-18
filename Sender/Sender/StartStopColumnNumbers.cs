
namespace Sender
{
    public class StartStopColumnNumbers
    {
        public static int[] ReturnStartAndStopColumnNumbers(int columnNumber, int columnCount)
        {
            int[] startstopColumnNumber = new int[2];
            if (columnNumber == 0)
            {
                startstopColumnNumber[0] = 0;
                startstopColumnNumber[1] = columnCount;
                return startstopColumnNumber;
            }
            else if (columnNumber == 1)
            {
                startstopColumnNumber[0] = 0;
                startstopColumnNumber[1] = 1;
                return startstopColumnNumber;
            }
            else
            {
                startstopColumnNumber[0] = 1;
                startstopColumnNumber[1] = columnCount;
                return startstopColumnNumber;
            }
        }
    }
}
