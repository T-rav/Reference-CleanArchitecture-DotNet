using Mustache.Reports.Domain.Report.Excel;
using Mustache.Reports.Domain.Report.Word;

namespace Mustache.Reports.Domain.Report
{
    public interface IReportGateway
    {
        RenderedDocumentOutput CreateWordReport(RenderWordInput input);
        RenderedDocumentOutput CreateExcelReport(RenderExcelInput input);
    }
}