using System;

namespace TemplateMethod
{
    public class PdfGenerator : Generator
    {
        protected override void PrepareData()
        {
            Console.WriteLine("Preparing data for pdf");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generating pdf file");
        }
    }
}
