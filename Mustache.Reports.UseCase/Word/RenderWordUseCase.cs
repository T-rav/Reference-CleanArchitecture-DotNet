﻿using System;
using Mustache.Reports.Domain;
using Mustache.Reports.Domain.Report;
using Mustache.Reports.Domain.Report.Word;
using StoneAge.CleanArchitecture.Domain.Messages;
using StoneAge.CleanArchitecture.Domain.Output;

namespace Mustache.Reports.UseCase.Word
{
    public class RenderWordUseCase : IRenderWordUseCase
    {
        private readonly IReportGateway _wordGateway;

        public RenderWordUseCase(IReportGateway wordGateway)
        {
            _wordGateway = wordGateway ?? throw new ArgumentNullException(nameof(wordGateway));
        }

        public void Execute(RenderWordInput inputTo, 
                            IRespondWithSuccessOrError<IFileOutput, ErrorOutput> presenter)
        {
            var result = _wordGateway.CreateWordReport(inputTo);

            if (result.HasErrors())
            {
                Respond_With_Errors(presenter, result);
                return;
            }

            Respond_With_File(inputTo, presenter, result);
        }

        private void Respond_With_File(RenderWordInput inputTo, 
                                       IRespondWithSuccessOrError<IFileOutput, ErrorOutput> presenter, 
                                       RenderedDocumentOutput result)
        {
            var reportMessage = new WordFileOutput(inputTo.ReportName, result.FetchDocumentAsByteArray());

            presenter.Respond(reportMessage);
        }

        private void Respond_With_Errors(IRespondWithSuccessOrError<IFileOutput, ErrorOutput> presenter, 
                                         RenderedDocumentOutput result)
        {
            var errors = new ErrorOutput();
            errors.AddErrors(result.ErrorMessages);
            presenter.Respond(errors);
        }
    }
}
