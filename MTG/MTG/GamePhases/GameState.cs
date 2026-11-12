using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.GamePhases
{
    internal interface IGameState
    {
        public void EnterState();
        public void ExitState();
        public void Process();
    }
}
