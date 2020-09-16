using System;

namespace Sender
{
    public class Column_Number
    {
        public static string TakeColumnNumberForColumnFilter(string UserInput)
        {
            Console.WriteLine("Enter 1 for Date & Time column filter and 2 for Comments Column filter");
            String ColumnNumber = Console.ReadLine();
            return ColumnNumber;
        }

    }
}
