using System.Collections.Generic;
using System.Linq;

namespace Checkout.Rules
{
    public sealed class DRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('D'))*15;
        }
    }
}