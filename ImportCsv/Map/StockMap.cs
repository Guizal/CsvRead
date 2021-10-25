using TinyCsvParser.Mapping;

namespace ImportCsv
{
    public class StockMap : CsvMapping<StockDetails>
    {
        public StockMap(): base()
        {
            MapProperty(0, x => x.Date);
            MapProperty(1, x => x.Close);
            MapProperty(2, x => x.Volume);
            MapProperty(3, x => x.Open);
            MapProperty(4, x => x.High);
            MapProperty(5, x => x.Low);
        }
    }
}
