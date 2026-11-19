using System;
using System.Collections.Generic;
using System.Text;
using MTG.Counters;

namespace MTG.Cards
{
    internal abstract class Creature : Permanent
    {
        int basePower = 0;
        int baseToughness = 0;

        public Creature(int bp = 0, int bt = 0)
        {
            basePower = bp;
            baseToughness = bt;

            tapped = false;

            counters = new List<Counter>();
        }


        
    }
}
