namespace Mustache.Reports.Domain.Pdf
{
    public interface IPdfGateway
    {
        RenderedDocumentOutput ConvertToPdf(RenderPdfInput inputMessage);
    }
}
