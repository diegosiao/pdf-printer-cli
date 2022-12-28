using PDFtoPrinter;

namespace pdf_printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
                throw new ArgumentException("Two arguments are expected: PDF file path and a name of a valid Windows Printer");

            if (!File.Exists(args[0]))
                throw new ArgumentException($"The file specified does not exists: {args[0]}");

            var fileInfo = new FileInfo(args[0]);

            var printTimeout = new TimeSpan(0, 30, 0);
            var printer = new PDFtoPrinterPrinter();

            printer.Print(new PrintingOptions(args[1], fileInfo.FullName), printTimeout);
        }
    }
}