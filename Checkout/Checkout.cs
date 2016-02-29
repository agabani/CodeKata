using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Checkout
    {
        private readonly List<char> _items = new List<char>();
        private readonly List<Rule> _rules;

        public Checkout(List<Rule> rules)
        {
            _rules = rules;
        }

        public void Scan(char item)
        {
            _items.Add(item);
        }

        public double Total()
        {
            return _rules.Sum(rule => rule.Calculate(_items));
        }
    }
}