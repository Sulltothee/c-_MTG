using System;
using System.Collections.Generic;
using System.Text;
using MTG.Cards;
using MTG.Counters;

namespace MTG
{
    internal class Player : IAttackable, IGetCounters
    {
        Card[] Deck;
        Card[] Hand;
        Card[] Graveyard;
        Card[] Exile;

        Permanent[] Permanents;
        public List<Counter> counters;

        int LandsPerTurn = 1;

        List<Mana> ManaPool = new List<Mana>();

        public void EmptyManaPool()
        {
            ManaPool = new List<Mana>();
        }

        public virtual void AddCounter(Counter counter)
        {
            counters.Add(counter);
            counters.Sort();
        }

        public virtual List<Counter> GetCounters()
        {
            return counters;
        }
    }
}
