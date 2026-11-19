using System;
using System.Collections.Generic;
using System.Text;

namespace MTG
{
    internal class Spell : IHaveOwnerController
    {
        public Player getController()
        {
            throw new NotImplementedException();
        }

        public Player getOwner()
        {
            throw new NotImplementedException();
        }

        public Player setController(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
