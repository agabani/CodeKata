using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Checkout
    {
        private readonly List<char> _items = new List<char>();

        public Checkout(Rules rules)
        {
        }

        public void Scan(char item)
        {
            _items.Add(item);
        }

        public double Total()
        {
            return _items.Count(i => i.Equals('A'))*50 + _items.Count(i => i.Equals('B'))*30 +
                   _items.Count(i => i.Equals('C'))*20 + _items.Count(i => i.Equals('D'))*15;
        }
    }
}