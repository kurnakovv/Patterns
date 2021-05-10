using System;
using TempleteMethod.Abstract;
using TempleteMethod.Concrete;

namespace TempleteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMiner csvDataMiner = new CSVDataMiner();
            DataMiner pdfDataMiner = new PDFDataMiner();
            DataMiner docDataMiner = new DocDataMiner();

            csvDataMiner.Mine("D://Path//file.csv");
            Console.WriteLine("\n==========================\n");
            pdfDataMiner.Mine("D://Path//file.pdf");
            Console.WriteLine("\n==========================\n");
            docDataMiner.Mine("D://Path//file.doc");
        }
    }
}
