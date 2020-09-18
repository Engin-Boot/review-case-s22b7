using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Receiver.Test
{
    public class ReceiverTestSuite
    {
        readonly ReadConsoleHandler _reader = new ReadConsoleHandler();
        readonly CsvWriteHandler _writer = new CsvWriteHandler();
        readonly string _fileName = "Example.csv";
        readonly Dictionary<string, int> _wordmap = new Dictionary<string, int>() { { "Hello", 2 }, { "Philips", 1 }, { "World", 2 } };

        [Fact]
        public void GivenListOfLinesThenReturnsWordCountMap()
        {
            List<String> testList = new List<String>() { "Hello", "World", "Philips", "Hello", "Philips", "and" };
            Dictionary<String, int> outcome = _reader.ListToWordCountMap(testList);
            Assert.Equal(_wordmap["Hello"], outcome["Hello"]);
        }
        [Fact]
        public void WhenFileArgumentIsHealthyThenCreateNewFile()
        {
            _writer.FilePathGen(_fileName);
            Assert.True(File.Exists(GetPath(_fileName)));
            Assert.Equal(0, new FileInfo(GetPath(_fileName)).Length);
        }
        [Fact]
        public void WhenFileisCorruptedThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => _writer.FilePathGen(""));
        }

        [Fact]
        public void WhenFileStreamFailsThenThrowException()
        {
            Assert.Throws<ApplicationException>(() => _writer.WriteToCsv(_wordmap, ""));
        }

        [Fact]
        public void WhenFileStreamSucceedsThenWriteOnFile()
        {
            _writer.WriteToCsv(_wordmap, GetPath(_fileName));
            Assert.Equal("Hello,2", File.ReadAllLines(GetPath(_fileName))[0]);
        }
        private static string GetPath(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }
    }
}
