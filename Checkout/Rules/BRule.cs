using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public sealed class BRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('B'))*30;
        }
    }
}