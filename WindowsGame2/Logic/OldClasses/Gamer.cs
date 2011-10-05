using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicOld
{
    public class Gamer
    {
        public int Live { get; set; }
        public int Money { get; set; }
        public int Score { get; set; }

        private List<Tower> _towers;

        public List<Tower> Towers
        {
            get { return _towers; }
            set { _towers = value; }
        }
        

        public Gamer(int startLive, int startMoney)
        {
            Live = startLive;
            Money = startMoney;
        }

    }
}
