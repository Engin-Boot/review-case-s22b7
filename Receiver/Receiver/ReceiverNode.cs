using System;
using System.Linq;
using System.Linq.Expressions;

namespace Receiver
{
    class ReceiverNode
    {
        static void Main(string[] args)
        {
            string[] value = ReadFromConsole();

            for(int i = 0 ; i <= value.Length ; i++)
            {
                Console.WriteLine(value[i]);
            }
        }

        public static string[] ReadFromConsole()
        {
            string ConsoleEntry;
            string[] ConsoleContent = { };
            ConsoleEntry = Console.ReadLine();
            while (!string.IsNullOrEmpty(ConsoleEntry))
            {
                ConsoleContent.Append(ConsoleEntry);
                ConsoleEntry = Console.ReadLine();
            }
            return ConsoleContent;
        }
   }
}
