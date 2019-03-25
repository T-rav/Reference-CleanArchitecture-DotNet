namespace Mustache.Reports.Domain.Csv
{
    public interface ICsvGateway
    {
        RenderedDocumentOutput ConvertToCsv(RenderCsvInput input);
    }
}
