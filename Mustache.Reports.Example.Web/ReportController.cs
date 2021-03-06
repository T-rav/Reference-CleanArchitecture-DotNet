﻿using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Mustache.Reports.Domain.Pdf;
using Mustache.Reports.Domain.Report.Word;
using StoneAge.CleanArchitecture.Presenters;

namespace Mustache.Reports.Example.Web
{
    [Route("api/report/v1/create")]
    public class ReportController  : Controller
    {
        private readonly IRenderWordUseCase _wordUsecase;
        private readonly IRenderAsWordThenPdfUseCase _pdfUsecase;
        private readonly DemoOptions _options;

        public ReportController(IRenderWordUseCase wordUsecase,
                                IRenderAsWordThenPdfUseCase pdfUsecase,
                                IOptions<DemoOptions> options)
        {
            _wordUsecase = wordUsecase;
            _pdfUsecase = pdfUsecase;
            _options = options.Value;
        }

        [HttpGet("word")]
        public IActionResult Create_Word()
        {
            var jsonData = Read_Report_Json();

            var inputMessage = new RenderWordInput
            {
                TemplateName = "ReportWithImages",
                ReportName = "ExampleReport.docx",
                JsonModel = jsonData
            };
            var presenter = new DownloadFilePresenter();
            _wordUsecase.Execute(inputMessage, presenter);
            return presenter.Render();
        }

        [HttpGet("pdf")]
        public IActionResult Create_Pdf()
        {
            var jsonData = Read_Report_Json();

            var inputMessage = new RenderWordInput
            {
                TemplateName = "ReportWithImages",
                ReportName = "ExampleReport.docx",
                JsonModel = jsonData
            };
            var presenter = new DownloadFilePresenter();
            _pdfUsecase.Execute(inputMessage, presenter);
            return presenter.Render();
        }

        private string Read_Report_Json()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var jsonPath = Path.Combine(basePath, _options.SampleDataLocation);
            var jsonData = System.IO.File.ReadAllText(jsonPath);
            return jsonData;
        }
    }
}
