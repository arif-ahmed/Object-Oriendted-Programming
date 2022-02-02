namespace AdapterDesignPattern.Example_01
{
    public class StockMarketXmlProvider
    {
        public string GetXmlData()
        {
            return "<stocks><stock><symbol>APPL</symbol><price>150</price></stock></stocks>";
        }
    }
}
