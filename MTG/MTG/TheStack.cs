using System;
using System.Collections.Generic;
using System.Text;

namespace MTG
{
    internal class TheStack
    {
        private TheStack instance;
        private TheStack()
        {
            spellStack = new Stack<Spell>();
        }
        public TheStack Instance()
        {
            if(instance == null)
            {
                new TheStack();
            }
            return instance;
        }

        Stack<Spell> spellStack;

        public Spell this[int Index]
        {
            get => spellStack.ToArray()[Index];
        }
    }
}
