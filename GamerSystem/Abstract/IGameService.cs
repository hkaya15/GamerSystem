using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Abstract
{
    public interface IGameService
    {
        void BuyGame(IEntity gamer,IEntity game);
        void ReturnBackGame(IEntity gamer, IEntity game);
    }
}
