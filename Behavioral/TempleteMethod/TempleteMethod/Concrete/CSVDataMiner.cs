using System;
using System.Collections.Generic;
using System.Text;
using TempleteMethod.Abstract;

namespace TempleteMethod.Concrete
{
    class CSVDataMiner : DataMiner
    {
        protected override string AnalyzeData(string data)
        {
            return $"Analyze {data}...";
        }
        protected override string ParseData(List<string> rowData)
        {
            return $"Parse {rowData}...";
        }
        protected override string SendReport(string analyze)
        {
            return "Mining finish complete!";
        }

        protected override bool CloseFile(string file)
        {
            System.Console.WriteLine($"Close the {file} file");
            return true;
        }

        protected override List<string> ExtractData(string file)
        {
            System.Console.WriteLine($"Extract the {file} file");
            return new List<string>();
        }

        protected override string OpenFile(string path)
        {
            return $"Open the CSV by path: {path}";
        }
    }
}
