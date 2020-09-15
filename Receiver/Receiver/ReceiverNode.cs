using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Receiver
{
    class ReceiverNode
    {
        static void Main(string[] args)
        {
            ListToWordCountMap(
                ReadFromConsole()
                );

        }

        public static List<String> ReadFromConsole()
        {
            string ConsoleEntry;
            List<String> ConsoleContent = new List<String>();
            while (!string.IsNullOrEmpty(ConsoleEntry = Console.ReadLine()))
                ConsoleContent.Add(ConsoleEntry);
            return ConsoleContent;
        }

        public static Dictionary<String,int> ListToWordCountMap (List<String> wordlist)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i=0; i<= wordlist.Count; i++)
            {
                if (wordCount.ContainsKey(wordlist[i]))
                    wordCount[wordlist[i]]++;
                else
                    wordCount.Add(wordlist[i], 1);
            }
            return wordCount;
        }
   }
}
