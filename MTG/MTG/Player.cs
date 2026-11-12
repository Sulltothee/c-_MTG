using System;
using System.Collections.Generic;
using System.Text;
using MTG.Cards;

namespace MTG
{
    internal class Player
    {
        Card[] Deck;
        Card[] Hand;
        Card[] Graveyard;
        Card[] Exile;

        IPermanent[] Permanents;

        int LandsPerTurn = 1;

        List<Mana> ManaPool = new List<Mana>();

        public void EmptyManaPool()
        {
            ManaPool = new List<Mana>();
        }
    }
}
