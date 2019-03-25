using System.IO;
using System.Reflection;
using Mustache.Reports.Domain.Pdf;
using Mustache.Reports.Domain.Report.Word;
using Mustache.Reports.Example.Console.Domain;

namespace Mustache.Reports.Example.Console
{
    public class ReportController
    {
        private readonly IRenderAsWordThenPdfUseCase _pdfUseCase;
        private readonly IRenderWordUseCase _wordUseCase;
        private readonly IConsolePresenter _presenter;

        public ReportController(IRenderAsWordThenPdfUseCase pdfUseCase, 
                                IRenderWordUseCase wordUseCase,
                                IConsolePresenter presenter)
        {
            _pdfUseCase = pdfUseCase;
            _wordUseCase = wordUseCase;
            _presenter = presenter;
        }

        public void Run(string reportOutputDirectory, 
                        string reportDataFilePath)
        {
            //Render_Pdf_Report(reportOutputDirectory, reportDataFilePath);

            Render_Word_Report(reportOutputDirectory, reportDataFilePath);
        }

        private void Render_Word_Report(string reportOutputDirectory,
                                        string reportDataFilePath)
        {
            var jsonData = Read_Report_Data(reportDataFilePath);
            var inputMessage = new RenderWordInput
            {
                TemplateName = "ReportWithImages",
                ReportName = "ExampleReport",
                JsonModel = jsonData
            };

            _wordUseCase.Execute(inputMessage, _presenter);

            _presenter.Render(reportOutputDirectory, "docx");
        }

        private void Render_Pdf_Report(string reportOutputDirectory, 
                                       string reportDataFilePath)
        {
            var jsonData = Read_Report_Data(reportDataFilePath);
            var inputMessage = Create_Word_Input_Message(jsonData);

            _pdfUseCase.Execute(inputMessage, _presenter);
    
            _presenter.Render(reportOutputDirectory, "pdf");
        }

        private static string Read_Report_Data(string reportDataFilePath)
        {
            var baseLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var readPath = Path.Combine(baseLocation, reportDataFilePath);

            var jsonData = File.ReadAllText(readPath);
            return jsonData;
        }

        private static RenderWordInput Create_Word_Input_Message(string jsonData)
        {
            var inputMessage = new RenderWordInput
            {
                TemplateName = "ReportWithImages",
                ReportName = "ExampleReport",
                JsonModel = jsonData
            };
            return inputMessage;
        }
    }
}
