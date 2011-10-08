using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DAL;

namespace Logic
{
    public class Monster:BasicMonster
    {
        #region Properties

        private int _health;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        private Effect _getsEffect;

        public Effect GetsEffect
        {
            get { return _getsEffect; }
            set { _getsEffect = value; }
        }

        private float _speed;

        public float Speed
        {
            get 
            {
                if (GetsEffect.ShockTime != 0) return Speed - Speed * GetsEffect.IceDamage;
                else return 0;
            }
            set { _speed = value; }
        }

        #endregion

        #region Initialization

        public Monster(int id)
        {
            Entities entity = new Entities();
            GetsEffect = new Effect();

            #region Mapping
            BasicMonster basic = (from p in entity.BasicMonsters where p.Id == id select p).Single();
            Health = basic.Health;
            Armor = basic.Armor;
            Speed = (float)basic.Speed;
            Skill = basic.Skill;
            Model = basic.Model;
            Texture = basic.Texture;
            Money = basic.Money;
            Lvl = basic.Lvl;
            Name = basic.Name;
            Id = basic.Id;
            
            #endregion

        }

        #endregion

        #region Game Function

        public void Step()      //Написать движение за кадр
        {

        }

        public void TickSecond()
        {
            Health = (int)(Health - GetsEffect.FireDamage * Skill.AntiFire - GetsEffect.PoisonDamage * Skill.AntiPoison);
            if (Health <= 0) Die();

            if (GetsEffect.PoisonTime != 0) GetsEffect.PoisonTime--;
            if (GetsEffect.FireTime != 0) GetsEffect.FireTime--;
            if (GetsEffect.IceDamage != 0) GetsEffect.IceDamage--;
            if (GetsEffect.ShockTime != 0) GetsEffect.ShockTime--;
        }

        private void Die()      //Реализовать смерть монстров
        {

        }

        #endregion

    }
}
