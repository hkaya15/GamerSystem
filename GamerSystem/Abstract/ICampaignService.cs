using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(IEntity game, double discount);
        void Discount(IEntity entity,double discount);

    }
}
