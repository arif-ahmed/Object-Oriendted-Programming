using Newtonsoft.Json;
using System.Xml.Linq;

namespace AdapterDesignPattern.Example_01
{
    public class XmlToJsonAdapter : IJsonDataProvider
    {
        private readonly StockMarketXmlProvider _xmlProvider;

        public XmlToJsonAdapter(StockMarketXmlProvider xmlProvider)
        {
            _xmlProvider = xmlProvider;
        }

        public string GetJsonData()
        {
            // Get XML data from the provider
            string xmlData = _xmlProvider.GetXmlData();

            // Convert XML to JSON
            var xmlDocument = XDocument.Parse(xmlData);
            string jsonData = JsonConvert.SerializeXNode(xmlDocument);

            return jsonData;
        }
    }
}
