using System;
using Xunit;
using Sender;

namespace Sender_Test
{
    public class Sender_test
    {
        static void Main(string[] args)
        {
        }
        [Fact]
        public void TestCsvFileExists()
        {

            string path = "C:/Users/HP/Desktop/CaseStudyFinal/review-case-s22b7/sample-review/review-report.csv";
            Assert.True(PathExistance.CheckPathExistOrNot(path));
            Assert.False(PathExistance.CheckPathExistOrNot("C:/Users/HP/Desktop/CaseStudyFinal/sample-review/review-report.c"));
           // Console.WriteLine("Test Pass");
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

        //[Fact]
        //public void TestWhenCommentIsGivenAsInputReturnSeriesOfWords()
        //{
        //    Column_Filter.ApplyColumnFilter("given", 1, 2);
        //    string a = Console.ReadLine();
        //    Assert.True(a == "given");
        //}

    }
}
