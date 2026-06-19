class Program
{
    static void Main()
    {
        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory wordFactory = new WordFactory();
        IDocument word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excel = excelFactory.CreateDocument();
        excel.Open();
    }
}