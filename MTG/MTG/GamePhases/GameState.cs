using System;
using System.Collections.Generic;
using System.Text;

namespace MTG.GamePhases
{
    internal interface IGameState
    {
        public void EnterState(GameManager context);
        public void ExitState(GameManager context);
        public void Process(GameManager context);
    }
}
