﻿namespace Mustache.Reports.Domain.Options
{
    public class MustacheReportOptions
    {
        public TemplateOptions Template { get; set; }
        public NodeAppOptions NodeApp { get; set; }

        public string LibreOfficeLocation { get; set; }
    }
}
