using GamerSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerSystem.Entities
{
    class Game: IEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int DownloadCount { get; set; }
    }
}
