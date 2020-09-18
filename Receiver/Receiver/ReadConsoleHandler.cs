using System;
using System.Collections.Generic;

namespace Receiver
{
    public class ReadConsoleHandler
    {
        public List<String> ReadFromConsole()
        {
            string consoleEntry;
            List<String> consoleContent = new List<String>();
            while ((consoleEntry = Console.ReadLine())!=null)
                consoleContent.Add(consoleEntry);
            return consoleContent;
        }

        public Dictionary<String, int> ListToWordCountMap(List<String> wordlist)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in wordlist)
            {
                if (wordCount.ContainsKey(word))
                      wordCount[word]++;
                else  wordCount.Add(word, 1);
            }
            return wordCount;
        }
    }
}
