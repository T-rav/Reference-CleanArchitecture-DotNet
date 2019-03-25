using Mustache.Reports.Domain.Report.Word;
using Xunit;

namespace Mustache.Reports.Domain.Tests.Word
{
    public class RenderWordInputTests
    {
        [Fact]
        public void Ctor_ShouldSetFileNamePropertyToDefault()
        {
            // arrange
            // act
            var actual = new RenderWordInput();
            // assert
            Assert.Equal("report.docx", actual.ReportName);
        }
    }
}
