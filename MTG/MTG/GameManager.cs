using System;
using System.Collections.Generic;
using System.Text;

namespace MTG
{
    public class GameManager
    {
        #region Singleton
        private static GameManager instance;
        private GameManager() { }
        public GameManager Instance()
        {
            if(instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }

        #endregion

        #region PhaseManager

        #endregion
    }
}
