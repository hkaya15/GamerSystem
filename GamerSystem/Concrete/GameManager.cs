using GamerSystem.Abstract;
using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Concrete
{
    class GameManager : IGameService , ICampaignService
    {
        public void AddCampaign(IEntity game,double discount)
        {
            Discount(game,discount);
            Console.WriteLine("{0} adlı oyunun yeni fiyatı {1} ", ((Game)game).Name, ((Game)game).Price);
        }

   

        public void BuyGame(IEntity gamer, IEntity game)
        {
            Console.WriteLine("{0} adlı Oyunu {1} Satın Aldı",((Game)game).Name,((Person)gamer).Name);
        }

        public void Discount(IEntity game,double discount)
        {
            ((Game)game).Price = ((Game)game).Price - discount;
            Console.WriteLine("İndirim Yapıldı");
        }


        public void ReturnBackGame(IEntity gamer, IEntity game)
        {
            
            Console.WriteLine("Oyun İade edildi");
        }
    }
}
