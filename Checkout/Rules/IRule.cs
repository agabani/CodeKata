using System.Collections.Generic;

namespace Checkout.Rules
{
    public interface IRule
    {
        double CalculatePriceDelta(IEnumerable<char> items);
    }
}