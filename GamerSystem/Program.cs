using GamerSystem.Abstract;
using GamerSystem.Concrete;
using GamerSystem.Entities;
using System;

namespace GamerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IVerificationService verification = new VerificationManager();
            IVerificationService verification1 = new MernisManager();

            PlayerManager playerManager = new PlayerManager(verification1);
            GameManager gameManager = new GameManager();

            IEntity game = new Game()
            {
                   Name = "GTA",
                   Price = 256.75,
                   DownloadCount = 4525
            };

            IEntity entity = new Person() {
                Name = "Hüseyin",
                NationalId = "1111111111",
                DateofBirth=    1992,
            };

            playerManager.Save(entity);
            gameManager.BuyGame(entity,game);
            gameManager.AddCampaign(game,25);
        }
    }
}
