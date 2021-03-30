using Adapter.BL.Abstract;

namespace Adapter.BL
{
    public class DollarParser : IXmlParser
    {
        public string ParseToXml(string money)
        {
            return $"<Dollar>{money} d</Dollar>";
        }
    }
}
