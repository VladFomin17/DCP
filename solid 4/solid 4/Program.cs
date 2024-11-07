using System;
using static solid_4.PrinterScanner;
using static solid_4.IPrinter;
using solid_4;


class Program
{
    static void Main(string[] args)
    {
        IPrinterScanner allInOnePrinter = new PrinterScanner();
        allInOnePrinter.Print("Документ для печати");
        allInOnePrinter.Scan("Документ для сканирования");

        Console.WriteLine();

        // Создаем экземпляр простого принтера
        IPrinter simplePrinter = new Printer();
        simplePrinter.Print("Документ для печати на простом принтере");
    }
}
