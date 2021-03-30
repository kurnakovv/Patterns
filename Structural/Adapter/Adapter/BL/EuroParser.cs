using Adapter.BL.Abstract;

namespace Adapter.BL
{
    public class EuroParser : IXmlParser
    {
        public string ParseToXml(string money)
        {
            return $"<Euro>{money} e</Euro>";
        }
    }
}
