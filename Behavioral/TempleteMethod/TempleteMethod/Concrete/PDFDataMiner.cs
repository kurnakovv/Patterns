using System.Collections.Generic;
using TempleteMethod.Abstract;

namespace TempleteMethod.Concrete
{
    class PDFDataMiner : DataMiner
    {
        protected override string AnalyzeData(string data)
        {
            return data;
        }
        protected override bool CloseFile(string file)
        {
            System.Console.WriteLine($"Close the PDF file: {file}");
            return true;
        }

        protected override List<string> ExtractData(string file)
        {
            System.Console.WriteLine($"Extract the PDF file: {file}");
            return new List<string>();
        }

        protected override string OpenFile(string path)
        {
            return $"Open the PDF by path: {path}";
        }
    }
}
