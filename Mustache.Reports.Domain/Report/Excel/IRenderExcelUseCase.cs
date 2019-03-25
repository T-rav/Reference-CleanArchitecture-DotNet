using StoneAge.CleanArchitecture.Domain;
using StoneAge.CleanArchitecture.Domain.Output;

namespace Mustache.Reports.Domain.Report.Excel
{
    public interface IRenderExcelUseCase : IUseCase<RenderExcelInput, IFileOutput>
    {
    }
}
