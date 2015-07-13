﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Temp_Databases.Heroes
{
    public abstract class Heroes
    {
        protected AttackModel mainAttack;
        protected AttackModel skillAttack;
        protected AttackModel ultSkillAttack;
        protected int attackSpeed;
        protected bool locked;
        protected int price;
        protected Int32 experience;

        public Heroes(Int32 experience, bool locked)
        {
            this.experience = experience;
            this.locked = locked;
        }

        public AttackModel MainAttack { get; private set; }
        public AttackModel SkillAttack { get; private set; }
        public AttackModel UltSkillAttack { get; private set; }
        public int AttackSpeed { get; private set; }
        public bool Locked { get; private set; }
        public int Price { get; private set; }
        public Int32 Experience { get; private set; }

        public void increaseExperience(int addition) {
            experience += addition;
        }

        public void unlockHeroes(ref int coin) {
            if (coin > price)
            {
                locked = false;
                coin = coin - price;
            }
            else
            {
                throw new Exception("NOT ENOUGH MONEY");
            }
        }
    }
}