using GamerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Entities
{
   public class Person:IEntity
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public int DateofBirth { get; set; }
    }
}
