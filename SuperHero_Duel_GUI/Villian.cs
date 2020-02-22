using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Duel_GUI
{
    /// <summary>
    /// A concrete Villian class that inherits the abstract MetaHuman class
    /// </summary>
    
    class Villian : MetaHuman
    {
        #region Attributes
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;
        public int BattlesFought { get; set; } = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for a Villian that uses the parent class's constructor
        /// </summary>
        /// <param name="name">The name of the Villian</param>
        /// <param name="health">The health of the Villian</param>
        /// <param name="attkMax">The attack maximum of the Villian</param>
        /// <param name="blockMax">The block maximum of the Villian</param>
        public Villian(string name = "SuperHero", double health = 0,
                       double attkMax = 0, double blockMax = 0)
                     : base(name)
        {
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
            BattlesFought = 0;
        }
        #endregion

        #region RandomNumbers
        /// <summary>
        /// A random number 
        /// </summary>
        Random rnd = new Random();
        #endregion

        #region Getters and Setters
        /// <summary>
        /// Set the Villian's number of battles fought
        /// </summary>
        public override void SetBattlesFought()
        {
            if (BattlesFought >= 3)
            {
                BattlesFought = 0;
            }
            else
            {
                BattlesFought++;
            }
        }

        /// <summary>
        /// Set the Villian's health
        /// </summary>
        /// <param name="health">The Villian's current health</param>
        public override void SetHealth(double health)
        {
            if (health <= 0)
            {
                Health = 0;
            }
            else
            {
                Health = health;
            }

        }

        /// <summary>
        /// Getter for the health attribute
        /// </summary>
        /// <returns>the villian's current health</returns>
        public override double GetHealth()
        {
            return Health;
        }

        /// <summary>
        /// Getter for the battles fought
        /// </summary>
        /// <returns>The number of battles fought</returns>
        public override int GetBattlesFought()
        {
            return BattlesFought;
        }
        #endregion        

        #region Attack
        /// <summary>
        /// Generates a random attack from 1 to the maximum attack
        /// </summary>
        /// <returns>The Villian's Attack</returns>
        public override double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }
        #endregion

        #region Block
        /// <summary>
        /// Generates a random attack from 1 to the maximum block
        /// </summary>
        /// <returns>The Villian's block</returns>
        public override double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

        #endregion

        #region ZeroBattles
        /// <summary>
        /// Set the Villian's Battle_Fought attributes to zero
        /// </summary>
        public override void ZeroBattle()
        {
            BattlesFought = 0;
        }

        #endregion
    }
}
