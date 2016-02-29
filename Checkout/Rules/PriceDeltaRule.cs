using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public sealed class PriceDeltaRule : IPriceDeltaRule
    {
        private readonly char _item;
        private readonly double _price;

        public PriceDeltaRule(char item, double price)
        {
            _item = item;
            _price = price;
        }

        public double CalculatePriceDelta(IEnumerable<char> items)
        {
            return items.Count(item => item.Equals(_item))*_price;
        }
    }
}