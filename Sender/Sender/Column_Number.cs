using System;

namespace Sender
{
    public class ColumnNumber
    {
        public static string TakeColumnNumberForColumnFilter()
        {
            Console.WriteLine("Enter 1 for Date & Time column filter and 2 for Comments Column filter");
            String columnNumber = Console.ReadLine();

            return columnNumber;
        }

    }
}
