namespace Structural.Adapters
{
    public class StockHistoryDb
    {
        public decimal[] GetAAPL()
            => new[] {121.06m, 6506m, 326m, 121.34m, 22.13m};

        public decimal[] GetMSFT()
            => new[] {12.546m, 42.506m, 31.26m, 125.34m, 226.13m};


        public decimal[] GetGOOG()
            => new[] {14.546m, 4.506m, 1.26m, 124m, 222.3m};
    }
}