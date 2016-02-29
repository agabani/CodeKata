using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public sealed class DiscountRule : IRule
    {
        private readonly char _item;
        private readonly int _quantity;
        private readonly double _discount;

        public DiscountRule(char item, int quantity, double discount)
        {
            _item = item;
            _quantity = quantity;
            _discount = discount;
        }

        public double CalculatePriceDelta(IEnumerable<char> items)
        {
            return -(items.Count(item => item.Equals(_item))/_quantity)*_discount;
        }
    }
}