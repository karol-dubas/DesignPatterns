using System;

namespace TemplateMethod
{
    class Program
    {
        // Metoda szablonowa pozwala na utworzenie głównego algorytmu w klasie bazowej, którego konkretne etapy
        // są nadpisywane przez klasy pochodne, bez zmiany jego struktury. Używamy, gdy mamy wiele klas używajacych
        // identycznego algorytmu, który różni się szczegółami implementacji.

        // Chcę przygotowywać dane i tworzyć z nich raporty do różnych plików np. excel i pdf. Ale powtarzający się
        // algorytm chcę zmienić tylko w wybranych etapach.

        static void Main(string[] args)
        {
            PdfGenerator pdfGenerator = new();
            pdfGenerator.GenerateReport();

            ExcelGenerator excelGenerator = new();
            excelGenerator.GenerateReport();
        }
    }
}
