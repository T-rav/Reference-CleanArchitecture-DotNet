namespace Mustache.Reports.Domain.Csv
{
    public class RenderCsvInput
    {
        public string Base64ExcelFile { get; set; }
        public string FileName { get; set; }

        public RenderCsvInput()
        {
            FileName = "CsvFile";
        }
    }
}
