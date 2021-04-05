using System;

namespace Structural.Adapters
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new StockApp();
            app.ShowStockHistory("AAPL");
        }
    }
}