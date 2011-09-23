using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Tower
    {
        // 'это тестовый коментария для github

        #region Properties

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private float _damage;

        public float Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        private float _reload;

        public float Reload
        {
            get { return _reload; }
            set { _reload = value; }
        }

        private bool _isGroundDamage;

        public bool IsGroundDamage
        {
            get { return _isGroundDamage; }
            set { _isGroundDamage = value; }
        }

        private bool _isAirDamage;

        public bool IsAirDamage
        {
            get { return _isAirDamage; }
            set { _isAirDamage = value; }
        }

        private TowerEffect _towerEffect;

        public TowerEffect TowerEffect
        {
            get { return _towerEffect; }
            set { _towerEffect = value; }
        }

        private float _radius;

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _priceNextLevel;

        public int PriceNextLevel
        {
            get { return _priceNextLevel; }
            set { _priceNextLevel = value; }
        }

        private int _sell;

        public int Sell
        {
            get { return _sell; }
            set { _sell = value; }
        }

        private bool _hasMassAttack;

        public bool HasMassAttack
        {
            get { return _hasMassAttack; }
            set { _hasMassAttack = value; }
        }

        private bool _isTower;

        public bool IsTower
        {
            get { return _isTower; }
            set { _isTower = value; }
        }

        #endregion

        #region Initialize

        public Tower(int id, int level)     //Инициализация башен
        {
            switch (id)     //Проход по id башен
            {
                case 1:
                    switch (level)      //Проход по уровням башен
                    {
                        case 1:         //Первый уровень
                            Name = "";
                            Reload = 2f;
                            Damage = 200;
                            IsGroundDamage = true;
                            IsAirDamage = true;
                            TowerEffect = new TowerEffect()
                            {
                                    //Эффекты отсытствуют пока что
                            };
                            Radius = 3f;
                            Price = 100;
                            PriceNextLevel = 500;
                            Sell = 50;
                            HasMassAttack = false;
                            IsTower = true;
                            break;

                        case 2:
                                    //Второй уровень по аналогии и далее
                            break;

                        default:
                            break;
                    }
                    break;

                case 2:
                            //Второй id по аналогии и далее
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
