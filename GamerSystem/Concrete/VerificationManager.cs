using GamerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Concrete
{
    public class VerificationManager : IVerificationService
    {
        public bool Check(IEntity person)
        {
            return true;
        }
    }
}
