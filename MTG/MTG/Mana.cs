using System;
using System.Collections.Generic;
using System.Text;

namespace MTG
{
    internal class Mana
    {
        public enum Colors {Colorless, White, Blue, Black, Red, Green}
        public enum ManaCostType {Spell, ActivatedAbility, TriggeredAbility}
        public virtual bool CheckSpend(ManaCostType costType, object cost = null)
        {
            return true;
        }
    }
}
