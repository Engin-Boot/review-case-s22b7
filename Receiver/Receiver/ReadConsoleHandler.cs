using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver
{
    public class ReadConsoleHandler
   {
       public List<String> ReadFromConsole()
        {
            string ConsoleEntry;
            List<String> ConsoleContent = new List<String>();
            while (!string.IsNullOrEmpty(ConsoleEntry = Console.ReadLine()))
                ConsoleContent.Add(ConsoleEntry);
            return ConsoleContent;
        }

        public Dictionary<String, int> ListToWordCountMap(List<String> wordlist)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < wordlist.Count; i++)
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
