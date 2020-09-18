using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Receiver
{
    public class ReadConsoleHandler
    {
        public static List<String> ReadFromConsole()
        {
            string consoleEntry;
            List<String> consoleContent = new List<String>();
            while ((consoleEntry = Console.ReadLine()) != null)
                consoleContent.Add(consoleEntry);
            return consoleContent;
        }

        public static Dictionary<String, int> ListToWordCountMap(List<String> wordlist)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in wordlist)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else wordCount.Add(word, 1);
            }
            return wordCount;
        }

        public static List<String> RemoveStopWords(List<String> wordlist)
        {
            XDocument xmlDoc = XDocument.Load
                (@"C:\\Users\320088165\OneDrive - Philips\Documents\Bootcamp\review-case-s22b7\Receiver\Receiver\StopWords.xml");
            List<String> StopList = xmlDoc.Root.Elements("item")
                                       .Select(element => element.Value)
                                       .ToList();
            wordlist.RemoveAll(x => StopList.Contains(x));
            return wordlist;
        }
    }
}
