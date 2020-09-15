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
            PathExistanceOfCsvFile pathchecker = new PathExistanceOfCsvFile();
            string path = "C:/Users/HP/Desktop/CaseStudyFinal/review-case-s22b7/sample-review/review-report.csv";
            Assert.True(pathchecker.CheckForPathExistOrNot(path));
            // Assert.False(pathchecker.CheckForPathExistOrNot("C:/Users/HP/Desktop/CaseStudyFinal/sample-review/review-report.c"));

        }
    }
}
