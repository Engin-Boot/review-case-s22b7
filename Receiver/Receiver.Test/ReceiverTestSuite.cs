using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Receiver.Test
{
    public class ReceiverTestSuite
    {
        string fileName = "Example.csv";
        Dictionary<string, int> wordmap = new Dictionary<string, int>() { { "Hello", 2 }, { "Philips", 1 }, { "World", 2 } };

        [Fact]
        public void GivenListOfLinesThenReturnsWordCountMap()
        {
            List<String> testList = new List<String>() { "Hello", "World", "Philips", "Hello", "Philips", "and" };
            Dictionary<String, int> outcome = ReadConsoleHandler.ListToWordCountMap(testList);
            Assert.Equal(wordmap["Hello"], outcome["Hello"]);
        }
        [Fact]
        public void WhenFileArgumentIsHealthyThenCreateNewFile()
        {
            CsvWriteHandler.FilePathGen(fileName);
            Assert.True(File.Exists(GetPath(fileName)));
            Assert.Equal(0, new FileInfo(GetPath(fileName)).Length);
        }
        [Fact]
        public void WhenFileisCorruptedThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => CsvWriteHandler.FilePathGen(""));
        }

        [Fact]
        public void WhenFileStreamFailsThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => CsvWriteHandler.WriteToCsv(wordmap, ""));
        }

        [Fact]
        public void WhenFileStreamSucceedsThenWriteOnFile()
        {
            CsvWriteHandler.WriteToCsv(wordmap, GetPath(fileName));
            Assert.Equal("Hello,2", File.ReadAllLines(GetPath(fileName))[0]);
        }
        private static string GetPath(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }
    }
}
