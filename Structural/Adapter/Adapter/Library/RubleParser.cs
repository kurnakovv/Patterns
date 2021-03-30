using Adapter.Library.Abstract;

namespace Adapter.Library
{
    public class RubleParser : IJsonParser
    {
        public string ParseToJson(string money)
        {
            return "{{money}: {" + money + " r}}";
        }
    }
}
