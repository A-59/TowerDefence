using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;

namespace Logic
{
    public class Player
    {
        #region Properties

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _life;

        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }

        private int _money;

        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private List<Tower> _towers;

        public List<Tower> Towers
        {
            get { return _towers; }
            set { _towers = value; }
        }

        #endregion

        #region Inicialization

        public Player(string name, int difficulty)
        {
            Name = name;
            if (difficulty == 0)
            {
                Life = 30;
                Money = 100;
            }
            if (difficulty == 1)
            {
                Life = 25;
                Money = 90;
            }
            if (difficulty == 2)
            {
                Life = 20;
                Money = 85;
            }
            if (difficulty == 3)
            {
                Life = 15;
                Money = 80;
            }
            if (difficulty == 4)
            {
                Life = 10;
                Money = 70;
            }
            Score = 0;
            Towers = new List<Tower>();
        }

        #endregion
    }
}
