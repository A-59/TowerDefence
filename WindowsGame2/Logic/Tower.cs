using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;
namespace Logic
{
    public class Tower:BasicTower
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int ToShot { get; set; }
        public int RemainTimeBuilding { get; set; }
        public bool IsBuilding { get; set; }

        public void TickFrame(int time)
        {
            if (!IsBuilding)
            {
                if (ToShot != 0) ToShot -= time;
                else Shot();
            }
            else
            {
                RemainTimeBuilding -= time;
            }
            
        }

        public void Shot()      //Добавить стрельбу
        {
        }
    }
}
