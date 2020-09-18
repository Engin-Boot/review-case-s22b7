using Xunit;

namespace Sender.Test
{
    public class SenderTest
    {
        string path = "review-report.cs";

        [Fact]
        public void TestCsvFileReader()
        {
            Assert.False(CsvFileReader.ReadCsvFile(path));
        }

        [Fact]
        public void TestWhenColumnNumberIsGivenThenReturnStartStopColumnNumber()
        {
            int startNum, stopNum;
            StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(1, 2, out startNum, out stopNum);
            Assert.True(startNum == 0 && stopNum == 1);
        }

        [Fact]
        public void TestWhenCommentIsGivenAsInputReturnSeriesOfWords()
        {
            string Comment = "No new Comment";
            Assert.Equal("new", Column_Filter.BreakLineToItems(Comment, ' ')[1]);
        }
    }
}
