using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Abstract
{
    public interface IVerificationService
    {
        bool Check(IEntity person);
    }
}
