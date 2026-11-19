using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Counters
{
    internal class Counter
    {
        public enum CounterTypes {P1P1, M1M1, Stun}
        CounterTypes counterType;

        public CounterTypes getType()
        {
            return counterType;
        }

        //returns the old type
        public CounterTypes setType(CounterTypes newType)
        {
            CounterTypes oldType = counterType;
            counterType = newType;
            return oldType;
        }
    }
}
