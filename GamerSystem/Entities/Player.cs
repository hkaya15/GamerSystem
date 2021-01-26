using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Entities
{
    class Player : Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public double Balance { get; set; }

    }
}
