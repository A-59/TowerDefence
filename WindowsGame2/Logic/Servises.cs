using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;

namespace Logic
{
    public class Servises
    {
        public List<Wave> GetLevelWaves(int id)
        {
            Entities entity = new Entities();
            return (from p in entity.Waves where p.LevelId == id select p).ToList();
        }
    }
}
