using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Duel_GUI
{
    class SuperHero
    {
        #region SuperHero Attributes
        /// <summary>
        /// The attributes of a SuperHero
        /// </summary>
        private string Name { get; set; } = "SuperHero";
        private double Health { get; set; } = 0;
        private double AttkMax { get; set; } = 0;
        private double BlockMax { get; set; } = 0;
        private int Battles_fought { get; set; } = 0;

        public void ZeroBattle()
        {
            Battles_fought = 0;
        }

        public int GetBattle()
        {
            return Battles_fought;
        }

        public void SetBattlesFought()
        {
            if(Battles_fought >= 3)
            {
                Battles_fought = 0;
            }
            else
            {
                Battles_fought++;
            }
        }

        public double GetHealth()
        {
            return Health;
        }

        public void SetHealth(double health)
        {
            if(health <= 0)
            {
                Health = 0;
            }
            else
            {
                Health = health;
            }
            
        }

        public string GetName()
        {
            return Name;
        }
        #endregion

        #region RandomNumbers
        /// <summary>
        /// A random number 
        /// </summary>
        Random rnd = new Random();
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for a SuperHero
        /// </summary>
        /// <param name="name">The name of the SuperHero</param>
        /// <param name="health">The health of the SuperHero</param>
        /// <param name="attkMax">The attack maximum of the SuperHero</param>
        /// <param name="blockMax">The block maximum of the SuperHero</param>
        public SuperHero(string name = "SuperHero", double health = 0,
                         double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
            Battles_fought = 0;
        }
        #endregion

        #region Attack
        /// <summary>
        /// Generate a random attack from 1 to the maximum attack
        /// </summary>
        /// <returns>The SuperHero's Attack</returns>
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        #endregion

        #region Block
        /// <summary>
        /// Generate a random attack from 1 to the maximum attack
        /// </summary>
        /// <returns>The SuperHero's Attack</returns>
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

        #endregion

    }
}
