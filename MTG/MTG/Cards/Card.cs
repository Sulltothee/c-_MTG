using System;
using System.Collections.Generic;
using System.Text;
using MTG.Counters;

namespace MTG.Cards
{
    internal class Card : IHaveOwnerController, IGetCounters
    {
        internal enum SuperTypes {Basic, Legendary, Snow}
        internal enum CardTypes {Land, Creature, Instant, Sorcery, Artifact, Enchantment, Planeswalker, Battle}
        internal enum SubTypes { }

        internal enum CardZones {Hand,Graveyard,Stack,Exile,Battlefield }

        Player owner;
        Player controller;
        public List<Counter> counters;

        List<SuperTypes> superTypes;
        List<CardTypes> cardTypes;
        List<SubTypes> subTypes;

        public Player getOwner()
        {
            return owner;
        }

        public Player getController()
        {
            return controller;
        }

        public Player setController(Player newController)
        {
            Player oldController = controller;
            controller = newController;
            return oldController;
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
