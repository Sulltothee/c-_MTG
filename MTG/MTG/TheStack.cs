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
            stack = new Stack<IOnStack>();
        }

        public TheStack Instance()
        {
            if(instance == null)
            {
                instance = new TheStack();
            }
            return instance;
        }

        public Stack<IOnStack> stack;

        public IOnStack this[int Index]
        {
            get => stack.ToArray()[Index];
        }
    }
}
