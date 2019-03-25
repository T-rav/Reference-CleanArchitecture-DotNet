using StoneAge.CleanArchitecture.Domain;
using StoneAge.CleanArchitecture.Domain.Output;

namespace Mustache.Reports.Domain.Csv
{
    public interface IRenderXlsxToCsvUseCase : IUseCase<RenderCsvInput, IFileOutput>
    {
    }
}
