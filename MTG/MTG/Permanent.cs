using System;
using System.Collections.Generic;
using System.Text;
using MTG.Cards;
using MTG.Counters;

namespace MTG
{
    internal class Permanent : Card
    {
        internal bool tapped = false;

        public bool isTapped()
        {
            return tapped;
        }

        public virtual void Tap()
        {
            if (!tapped) tapped = true;
        }

        public virtual void Untap()
        {
            if (tapped)
            {
                foreach (Counter counter in counters)
                {
                    if (counter.getType() == Counter.CounterTypes.Stun)
                    {
                        counters.Remove(counter);
                        return;
                    }
                }

                tapped = false;
            }
        }

        public virtual bool Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
