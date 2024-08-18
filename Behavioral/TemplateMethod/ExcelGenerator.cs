using System;

namespace TemplateMethod
{
    public class ExcelGenerator : Generator
    {
        // Mogę nadpisać metody, które wymagają zmiany bazowej implementacji
        protected override void GetData()
        {
            Console.WriteLine("Excel get data");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Preparing data for excel");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generating excel file");
        }
    }
}
