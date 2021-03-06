﻿using System.Collections.Generic;
using System.Linq;
using Checkout.Rules;

namespace Checkout
{
    public class Checkout
    {
        private readonly List<char> _items = new List<char>();
        private readonly List<IPriceDeltaRule> _rules;

        public Checkout(List<IPriceDeltaRule> rules)
        {
            _rules = rules;
        }

        public void Scan(char item)
        {
            _items.Add(item);
        }

        public double CalculateTotalPrice()
        {
            return _rules.Sum(rule => rule.CalculatePriceDelta(_items));
        }
    }
}