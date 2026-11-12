using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.Cards
{
    internal interface IStateBasedEffect
    {
        int GetLayer();

        void UpdateStates(GameManager context);
    }
}
