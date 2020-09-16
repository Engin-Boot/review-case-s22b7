using Sender;
using Xunit;

namespace Sender_Test
{
    public class Sender_Test
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
            int StartNum, StopNum;
            StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(1, 2,out StartNum,out StopNum);
                Assert.True(StartNum == 0 && StopNum == 1);
        }

        [Fact]
        public void TestWhenCommentISGivenAsInputReturnSeriesOfWords()
        {
            string Comment = "No new Comment";
            Assert.Equal("new",Column_Filter.BreakLineToItems(Comment, ' ')[1]);
        }
    }
}
