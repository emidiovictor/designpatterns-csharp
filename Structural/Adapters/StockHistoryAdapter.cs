using System;
using System.Data;

namespace Structural.Adapters
{
    public class StockHistoryAdapter : StockHistoryTarget
    {
        private readonly StockHistoryDb _adaptee = new();

        public override DataTable GetStockPrices(string ticker)
        {
            var history = ticker switch
            {
                "GOOG" => _adaptee.GetGOOG(),
                "AAPL" => _adaptee.GetAAPL(),
                "MSFT" => _adaptee.GetMSFT(),
                _ => throw new NotImplementedException()
            };
            var results = new DataTable();
            results.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            results.Columns.Add(new DataColumn("Price", typeof(decimal)));

            var dt = new DateTime(2015, 11, 7);

            for (int i = 0; i < 5; i++)
            {
                DataRow row = results.NewRow();
                row[0] = dt;
                row[1] = history[i];
                results.Rows.Add(row);
                dt = dt.AddMonths(-1);
            }

            return results;
        }
    }
}