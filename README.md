# pdf-printer CLI

This is a small Windows CLI utility to print PDF files and take advantage of amazing NuGet package [PDFfoPrinter](https://www.nuget.org/packages/PDFtoPrinter).

To use this CLI just pass the path to the file and a valid local or network Windows Printer.

```bash
.\pdf-printer.exe file-1.pdf "HPF498BE (HP Ink Tank Wireless 410 series)"
```

Binaries comes in two .NET flavors:

* [Self-Contained ready to run CLI](https://github.com/diegosiao/pdf-printer-cli/blob/master/binaries/pdf-printer-cli-selfcontained-win-x64.zip)

* [.NET6+ SDK or Runtime dependent](https://github.com/diegosiao/pdf-printer-cli/blob/master/binaries/pdf-printer-cli-dotnet6-dependent-win-x64.zip)

## All Credits to PDFtoPrinter

[PDFtoPrinter on Github](https://github.com/svishnevsky/PDFtoPrinter)
