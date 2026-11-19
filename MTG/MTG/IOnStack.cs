using System;
using System.Collections.Generic;
using System.Text;
using MTG.GamePhases;

namespace MTG
{
    internal interface IOnStack
    {
        enum StackObjectTypes {Spell, ActivatedAbility, TriggeredAbility}

        StackObjectTypes GetStackType();
        void OnResolution(GameManager context);
        bool GetCounterable();

        
    }
}
