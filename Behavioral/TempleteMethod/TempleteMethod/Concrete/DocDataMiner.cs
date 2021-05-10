using System.Collections.Generic;
using TempleteMethod.Abstract;

namespace TempleteMethod.Concrete
{
    class DocDataMiner : DataMiner
    {
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
            return $"Open the file Doc by path: {path}";
        }
    }
}