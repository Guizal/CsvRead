using System;
using System.Linq;
using TinyCsvParser;
using System.Text;

namespace ImportCsv
{
    public class Program
    {
        static void Main(string[] args)
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            StockMap csvMapper = new StockMap();
            CsvParser<StockDetails> csvParser = new CsvParser<StockDetails>(csvParserOptions, csvMapper);
            var result = csvParser
                         .ReadFromFile(@"stock.csv", Encoding.ASCII)
                         .ToList();
            Console.WriteLine("Date" + "Close" + "Volume" + "Open" + "High" + "Low");
            foreach (var details in result)
            {
                Console.WriteLine(details.Result.Date + " " + details.Result.Close + " " + details.Result.Volume + " " + details.Result.Open + " " + details.Result.High + " " + details.Result.Low);
            }
        }
    }
}