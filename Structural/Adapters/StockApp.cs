using System;
using System.Data;

namespace Structural.Adapters
{
    public class StockApp
    {
        public void ShowStockHistory(string ticker)
        {
            var adapter = new StockHistoryAdapter();

            DataTable history = adapter.GetStockPrices(ticker);

            foreach (DataRow row in history.Rows)
            {
                var dt = (DateTime) row[0];
                var price = (decimal) row[1];
                Console.WriteLine("ON {0:yyyy MMMM dd} {1} was ${2:0.00}", dt, ticker, price);
            }
        }
        
    }
}