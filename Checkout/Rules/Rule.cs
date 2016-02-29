using System.Collections.Generic;

namespace Checkout.Rules
{
    public abstract class Rule
    {
        public abstract double Calculate(IEnumerable<char> items);
    }
}