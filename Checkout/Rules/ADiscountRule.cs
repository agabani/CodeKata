using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public class ADiscountRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return -items.Count(i => i.Equals('A'))/3*20;
        }
    }
}