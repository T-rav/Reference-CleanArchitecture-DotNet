using StoneAge.CleanArchitecture.Domain;
using StoneAge.CleanArchitecture.Domain.Output;

namespace Mustache.Reports.Domain.Pdf
{
    public interface IRenderDocxToPdfUseCase : IUseCase<RenderPdfInput, IFileOutput>
    {
    }
}