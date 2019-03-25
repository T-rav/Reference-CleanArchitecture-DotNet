using Mustache.Reports.Domain.Report.Excel;
using Xunit;

namespace Mustache.Reports.Domain.Tests.Excel
{
    public class RenderExcelInputTests
    {
        [Fact]
        public void Ctor_ShouldSetFileNamePropertyToDefault()
        {
            // arrange
            // act
            var actual = new RenderExcelInput();
            // assert
            Assert.Equal("report.xlsx", actual.ReportName);
        }

        [Fact]
        public void Ctor_ShouldSetSheetNumberToOne()
        {
            // arrange
            // act
            var actual = new RenderExcelInput();
            // assert
            Assert.Equal(1, actual.SheetNumber);
        }
    }
}
