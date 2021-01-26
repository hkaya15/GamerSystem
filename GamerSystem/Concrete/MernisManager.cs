using GamerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Concrete
{
    public class MernisManager : IVerificationService
    {
        public bool Check(IEntity person)
        {
            Console.WriteLine("Mernis Kontrol edildi");
            return true;
        }
    }
}
