
using Xunit;
using Sender;

namespace SenderTest
{
    public class SenderTest
    {
        [Fact]
        public void TestFilePathExists()
        {
            string path = "review-report.csv";
            Assert.False(PathExistance.CheckPathExistOrNot(path));
            string path1 = "C:/Users/HP/Desktop/Git_CaseStudy_Final/review-case-s22b7/sample-review/review-report.csv";
            Assert.True(PathExistance.CheckPathExistOrNot(path1));
        }

        [Fact]
        public void TestCsvFileReader()
        {
            string path = "review_report.csv";
            Assert.False(CsvFileReader.ReadCsvFile(path));
            string path1 = "C:/Users/HP/Desktop/Git_CaseStudy_Final/review-case-s22b7/sample-review/review-report.csv";
            Assert.True(PathExistance.CheckPathExistOrNot(path1));
        }

        [Fact]
        public void TestWhenColumnNumberIsGivenThenReturnStartStopColumnNumber()
        {
            //column1
            int[] startStopColumnNumber = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(1, 2);
            Assert.True(startStopColumnNumber[0]==0 && startStopColumnNumber[1]==1);
            //column2
            int[] startStopColumnNumber1 = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(2, 2);
            Assert.True(startStopColumnNumber1[0] == 1 && startStopColumnNumber1[1] == 2);
            //complete csv file both columns
            int[] startStopColumnNumber2 = StartStopColumnNumbers.ReturnStartAndStopColumnNumbers(0, 2);
            Assert.True(startStopColumnNumber2[0] == 0 && startStopColumnNumber2[1] == 2);

        }

        [Fact]
        public void TestWhenCommentIsGivenAsInputReturnSeriesOfWords()
        {
            //columnfilter
            string Comment = "No new Comment";
            string[] words = ConvertLineToTheSeriesOfWords.ConvertLineToSeriesOfWords(Comment);
            string[] actualSeriesWords = { "No", "new", "Comment" };
            Assert.True(words[0] == actualSeriesWords[0] && words[1] == actualSeriesWords[1] && words[2] == actualSeriesWords[2]);

        }

        //Extra test cases

        [Fact]
        public void SplitLineIntoColumn()
        {
            //columnfilter
            string line = "12/09/2020 , comment written";
            string[] columns = ColumnFilter.ApplyColumnFilter(line, 0, 1);
            string[] actualColumn = line.Split(',');
            Assert.True(columns[0]==actualColumn[0] && columns[1]==actualColumn[1]);
        }
        
        [Fact]
        public void SplitLinesIntoLine()
        {
            //seriesofwords
            string[] lines = { "No Comment", "Not Required" };
            string line = lines[0];
            string actualLine1 = LineLoop.ApplyLineLoop(lines, 0);
            Assert.True(line== actualLine1);
        }
        [Fact]
        public void ReadCsvFileWhenPathIsGiven()
        {
            //series of words
            string path = "C:/Users/HP/Desktop/Git_CaseStudy_Final/review-case-s22b7/sample-review/review-report.csv";
            string[] actuallines = System.IO.File.ReadAllLines(path);
            string[] lines = SeriesOfWords.ConvertCommentsToSeriesOfWords(path, "1");
            Assert.True(lines[0] == actuallines[0] && lines[1]==actuallines[1]);
        }
    }
}
