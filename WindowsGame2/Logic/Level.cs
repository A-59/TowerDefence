using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;

namespace Logic
{
    public class Level
    {
        public int NumberLevel { get; set; }
        public int NumberMonster { get; set; }
        public List<Wave> Waves { get; set; }

        public Level(int id)
        {

        }
    }
}
