using Adapter.BL.Abstract;
using Adapter.Library;
using Adapter.Library.Abstract;

namespace Adapter.BL
{
    public class XmlToJsonRubleParserAdapter : IXmlParser
    {
        public XmlToJsonRubleParserAdapter()
        {
            // Aggregation can be used, but I decided to hide the library details from the client.
            _jsonParser = new RubleParser();
        }

        private readonly IJsonParser _jsonParser;

        public string ParseToXml(string money)
        {
            return _jsonParser.ParseToJson(money);
        }
    }
}
