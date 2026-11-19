using System;
using System.Collections.Generic;
using System.Text;
using MTG.Counters;

namespace MTG
{
    internal interface IGetCounters
    {
        public void AddCounter(Counter counter);
        public List<Counter> GetCounters();
    }
}
