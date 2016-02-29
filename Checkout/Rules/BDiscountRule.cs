using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public sealed class BDiscountRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return -items.Count(i => i.Equals('B'))/2*15;
        }
    }
}