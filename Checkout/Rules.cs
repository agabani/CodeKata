using System.Collections;
using System.Collections.Generic;

namespace Checkout
{
    public class Rules : IEnumerable<Rule>
    {
        private readonly List<Rule> _rules;

        public Rules(List<Rule> rules)
        {
            _rules = rules;
        }

        public IEnumerator<Rule> GetEnumerator()
        {
            return _rules.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}