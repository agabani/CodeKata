using System.Collections.Generic;

namespace Checkout.Rules
{
    public interface IRule
    {
        double Calculate(IEnumerable<char> items);
    }
}