using StoneAge.Synchronous.Process.Runner.PipeLineTask;

namespace Mustache.Reports.Data.Csv
{
    public class XlsxToCsvTask : GenericPipeLineTask
    {
        public XlsxToCsvTask(string libreOfficePath, string xlsxPath, string outputDirectory) : base(libreOfficePath, $"--norestore --nofirststartwizard --headless --convert-to csv \"{xlsxPath}\" --outdir \"{outputDirectory}\"")
        {
        }
    }
}
