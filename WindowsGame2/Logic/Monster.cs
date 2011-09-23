using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Monster
    {
        // 'это тестовый коментария для github
        #region Properties

        private int _idMonster;

        public int IdMonster
        {
            get { return _idMonster; }
            set { _idMonster = value; }
        }
        

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _helth;

        public int Helth
        {
            get { return _helth; }
            set { _helth = value; }
        }

        private float _speed;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private float _armor;

        public float Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        private int _money;

        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }

        private bool isBoss;

        public bool IsBoss
        {
            get { return isBoss; }
            set { isBoss = value; }
        }

        private MonsterEffect _monsterEffect;

        public MonsterEffect MonsterEffect
        {
            get { return _monsterEffect; }
            set { _monsterEffect = value; }
        }

        private bool _isFly;

        public bool IsFly
        {
            get { return _isFly; }
            set { _isFly = value; }
        }

        private List<TowerEffect> _getsEffects;

        public List<TowerEffect> GetsEffects
        {           
            get { return _getsEffects; }
            set { _getsEffects = value; }
        }
        
        
        #endregion

        #region Initialize

        public Monster(int id, int level)   //Инициализация монстров
        {
            switch (id)     //Проход по id монстров
            {
                case 1:
                    switch (level)      //Проход по уровням монстров
                    {
                        case 1:         //Первый уровень
                            Name = " ";
                            Helth = 100;
                            Speed = 2f;
                            Armor = 0.3f;
                            Money = 1;
                            IsBoss = false;
                            MonsterEffect = new MonsterEffect()
                            {
                                //эффектов пока нету
                            };
                            IsFly = false;
                            break;
                        case 2:
                                        //Второй уровень по аналогии и далее
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                            //Второй id и далее
                    break;

                default:
                    break;
            }
        }

        #endregion

    }
}
