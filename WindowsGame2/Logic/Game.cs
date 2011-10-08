using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;

namespace Logic
{
    public class Game
    {
        #region Properties

        private bool _isGaming;

        public bool IsGaming
        {
            get { return _isGaming; }
            set { _isGaming = value; }
        }

        private Player _player;

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public int RemainTime { get; set; }

        public List<Wave> Waves { get; set; }

        public List<Monster> WaveMonsters { get; set; }

        #endregion

        public void StartLevel(int LevelId, string name, int difficulty)
        {
            _isGaming = true;
            Player = new Player(name, 1);
            Servises servises = new Servises();
            Waves = servises.GetLevelWaves(LevelId);
            RemainTime = (from p in Waves where p.WaveNumber == 1 select p.TimeWave).Single();
        }

        private void Timer()
        {
            int i = 0;
            while (IsGaming)
            {
                i++;
                while (IsGaming && i == 50)
                {
                    i = 0;
                    TickSecond();
                }
                System.Threading.Thread.Sleep(20);
                TickFrame();
            }

        }

        private void TickFrame()  //обновление каждый кадр
        {
            for (int i = 0; i < Player.Towers.Count; i++)
            {
                Player.Towers[i].TickFrame(50);
            }
            //движение монстров
            //выпуск монстров
        }

        private void TickSecond()   //обновление каждую секунду
        {
            
        }
    }
}
