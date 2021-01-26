using GamerSystem.Abstract;
using GamerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Concrete
{
   public class PlayerManager : IPersonService
    {
        private IVerificationService _verificationChecker;

        public PlayerManager(IVerificationService verificationChecker)
        {
            _verificationChecker = verificationChecker;
        }

        public void Delete(IEntity person)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Save(IEntity person)
           
        {
            if (_verificationChecker.Check(person))
            {
                Console.WriteLine("Kullanıcı Kaydedildi: "+((Person)person).Name);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }

        public void Update(IEntity person)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
