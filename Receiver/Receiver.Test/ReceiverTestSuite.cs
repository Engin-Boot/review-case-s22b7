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
        Dictionary<string, int> wordmap = new Dictionary<string, int>() { { "Hello", 2 }, { "Philips", 1 }, { "World", 2 } };


        [Fact]
        public void GivenListOfLinesThenReturnsWordCountMap()
        {
            List<String> testList = new List<String>() { "Hello", "World", "Philips", "Hello", "Philips", "and" };
            Dictionary<String,int>outcome = reader.ListToWordCountMap(testList);
            Assert.Equal(wordmap["Hello"],outcome["Hello"]);
        }
        [Fact]
        public void WhenFileArgumentIsHealthyThenCreateNewFile()
        {
            writer.FilePathGen(fileName);
            Assert.True(File.Exists(getPath(fileName)));
            Assert.Equal(0, new FileInfo(getPath(fileName)).Length);
        }
        [Fact]
        public void WhenFileisCorruptedThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => writer.FilePathGen(""));
        }

        [Fact]
        public void WhenFileStreamFailsThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => writer.WriteToCSV(wordmap,""));
        }

        [Fact]
        public void WhenFileStreamSucceedsThenWriteOnFile()
        {
            writer.WriteToCSV(wordmap, getPath(fileName));
            Assert.Equal("Hello,2",File.ReadAllLines(getPath(fileName))[0]);
        }
        private static string getPath(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), fileName);
        } 
    }
}
