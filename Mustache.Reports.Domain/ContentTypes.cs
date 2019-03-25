namespace Mustache.Reports.Domain
{
    public static class ContentTypes
    {
        public static ContentType Excel = new ContentType {Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"};
        public static ContentType Word = new ContentType{Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"};
        public static ContentType Pdf = new ContentType{Value = "application/pdf"};
    }
}
