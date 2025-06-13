using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        PDFgeneratereport pDFgeneratereport = new PDFgeneratereport();
        CSVgeneratereport cSVgeneratereport = new CSVgeneratereport();

        pDFgeneratereport.generate_report();
        Console.WriteLine("");
        cSVgeneratereport.generate_report();
    }
}