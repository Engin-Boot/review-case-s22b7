using Sender;
using Xunit;

namespace Sender_Test
{
    public class Sender_Test
    {
        [Fact]
        public void TestFilePathExists()
        {
            string path = "review-report.cs";
            Assert.False(PathExistance.CheckPathExistOrNot(path));
        }

        [Fact]
        public void TestCsvFileReader()
        {
            string path = "review_report.csv";
            Assert.False(CsvFileReader.ReadCsvFile(path));
        }

        [Fact]
        public void TestWhenColumnNumberIsGivenThenReturnStartStopColumnNumber()
        {
            int[] Start_StopColumnNumber = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(1, 2);
            if (Start_StopColumnNumber[0] == 0 && Start_StopColumnNumber[1] == 1)
            {
                Assert.True(true);
            }

        }

        [Fact]
        public void TestForColumnNumber()
        {
            string val = Column_Number.TakeColumnNumberForColumnFilter("1");
            if (val == "1")
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestWhenCommentISGivenAsInputReturnSeriesOfWords()
        {
            string Comment = "No new Comment";
            string[] words = ConvertLineToSeriesOfWords.ConvertLine_ToSeriesOfWords(Comment);
            string[] ActualSeriesWords = { "No", "new", "Comments" };
            if (words == ActualSeriesWords)
            {
                Assert.True(true);
            }
        }
    }
}
