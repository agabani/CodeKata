using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public abstract class Rule
    {
        public abstract double Calculate(IEnumerable<char> items);
    }

    public class ARule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('A'))*50;
        }
    }

    public class BRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('B'))*30;
        }
    }

    public class CRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('C'))*20;
        }
    }

    public class DRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return items.Count(i => i.Equals('D'))*15;
        }
    }

    public class ADiscountRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return -items.Count(i => i.Equals('A'))/3*20;
        }
    }

    public class BDiscountRule : Rule
    {
        public override double Calculate(IEnumerable<char> items)
        {
            return -items.Count(i => i.Equals('B'))/2*15;
        }
    }
}