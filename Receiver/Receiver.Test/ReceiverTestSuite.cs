using System;
using System.Collections.Generic;
using System.IO;
using Receiver;
using Xunit;

namespace Receiver.Test
{
    public class ReceiverTestSuite
    {
        ReadConsoleHandler reader = new ReadConsoleHandler();
        CSVwriteHandler writer = new CSVwriteHandler();
        string fileName = "Example.csv";


        [Fact]
        public void GivenListOfLinesThenReturnsWordCountMap()
        {
            List<String> testList = new List<String>() { "Hello", "World", "Philips", "Hello", "Philips", "and" };
            Dictionary<String,int>outcome = reader.ListToWordCountMap(testList);
            Assert.True(outcome["Hello"] == 2);
        }
        [Fact]
        public void WhenFileDoesNotExistThenCreateNewFile()
        {
            if (File.Exists(getPath(fileName))) 
                File.Delete(getPath(fileName));
            writer.FilePathGen(fileName);
            Assert.True(File.Exists(getPath(fileName)));
        }
        [Fact]
        public void WhenFileExistThenDeleteOldCreateNewFile()
        {
            WriteinFile();
            writer.FilePathGen(fileName);
            Assert.True(File.Exists(getPath(fileName)));
            Assert.True(File.ReadAllLines(getPath(fileName)) == null);
        }


        private void WriteinFile()
        {
            StreamWriter file = new StreamWriter(@getPath(fileName), false);
            file.WriteLine("Test line");
        }

        private static string getPath(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), fileName);
        } 
    }
}
