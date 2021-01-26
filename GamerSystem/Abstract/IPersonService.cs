using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Abstract
{
    public interface IPersonService
    {
        void Save(IEntity person);
        void Update(IEntity person);
        void Delete(IEntity person);
    }
}
