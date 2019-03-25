using Mustache.Reports.Domain.Csv;
using Xunit;

namespace Mustache.Reports.Domain.Tests
{
    public class RenderCsvInputTests
    {
        [Fact]
        public void Ctor_WhenNoNameGiven_ShouldDefaultToReport()
        {
            //---------------Arrange-------------------
            //---------------Act----------------------
            var sut = new RenderCsvInput();
            //---------------Assert-----------------------
            var expected = "CsvFile";
            Assert.Equal(expected, sut.FileName);
        }

        [Fact]
        public void Ctor_WhenNameGiven_ShouldUseName()
        {
            //---------------Arrange-------------------
            //---------------Act----------------------
            var sut = new RenderCsvInput { FileName = "NewReport"};
            //---------------Assert-----------------------
            var expected = "NewReport";
            Assert.Equal(expected, sut.FileName);
        }

    }
}
