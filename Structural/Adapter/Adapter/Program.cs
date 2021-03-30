using Adapter.BL;
using Adapter.BL.Abstract;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IXmlParser parser = new DollarParser();
            Console.WriteLine(parser.ParseToXml("50"));

            parser = new EuroParser();
            Console.WriteLine(parser.ParseToXml("100"));

            parser = new XmlToJsonRubleParserAdapter();
            Console.WriteLine(parser.ParseToXml("10000"));

            Console.ReadLine();
        }
    }
}
