using System.Data;

namespace Structural.Adapters
{
    public abstract class StockHistoryTarget
    {
        public abstract DataTable GetStockPrices(string ticker);
    }
}