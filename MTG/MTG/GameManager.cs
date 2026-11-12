using System;
using System.Collections.Generic;
using System.Text;
using MTG.GamePhases;

namespace MTG
{
    public class GameManager
    {
        #region Singleton
        private static GameManager instance;
        private GameManager() 
        {
            
        }
        public GameManager Instance()
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
        #endregion

        #region PhaseManager
        int currentStateIndex = 0;
        IGameState[] gameStates = new IGameState[] {new Untap(), new Upkeep(), new Draw(), new MainPhase(), new BeginningCombat(), new DeclareAttackers(), new DeclareBlockers(), new EndCombat(), new EndStep(), new Cleanup()};
        Queue<int> PhaseQueue = new Queue<int>();

        void NewTurn()
        {
            //Adding all the phases to the queue
            AddPhases(new int[]{0,1,2,3,4,5,6,7,3,8,9 });
            LandsPlayed = 0;
        }

        void AddPhases(int[] Phases)
        {
            for(int i = 0; i < Phases.Length; i++)
            {
                if (Phases[i] < gameStates.Length)
                {
                    PhaseQueue.Enqueue(Phases[i]);
                }
            }
        }
        #endregion

        #region Game Loop
        Player[] players = new Player[] { new Player(), new Player() };

        bool playing = true;
        int LandsPlayed = 0;

        void GameLoop()
        {
            NewTurn();
        }

        void ChangePhase()
        {
            //Empty mana pools
            foreach(Player p in players)
            {
                p.EmptyManaPool();
            }
        }

        void UpdateStateBasedEffects()
        {
            //TODO update state based effects
        }
        #endregion
    }
}
