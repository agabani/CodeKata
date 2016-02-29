using System.Collections.Generic;

namespace Checkout.Rules
{
    public interface IPriceDeltaRule
    {
        double CalculatePriceDelta(IEnumerable<char> items);
    }
}