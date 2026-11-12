using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Cards
{
    internal class Card
    {
        internal enum SuperTypes {Basic, Legendary, Snow}
        internal enum CardTypes {Land, Creature, Instant, Sorcery, Artifact, Enchantment, Planeswalker, Battle}
        internal enum SubTypes { }

        internal enum CardZones {Hand,Graveyard,Stack,Exile,Battlefield }

        List<SuperTypes> superTypes;
        List<CardTypes> cardTypes;
        List<SubTypes> subTypes;
    }
}
