using System;
using System.Collections.Generic;
using System.Text;

namespace MTG
{
    internal interface IHaveOwnerController
    {
        public Player getOwner();
        public Player getController();
        public Player setController(Player player);
    }
}
