using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Duel_GUI
{
    /// <summary>
    /// A abstract class that is not estanciated.
    /// </summary>
    abstract class MetaHuman
    {
        #region Attributes
        /// <summary>
        /// The Attributes of a MetaHuman
        /// </summary>
        public string Name { get; set; } = "SuperHero";
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for a MetaHuman
        /// </summary>
        /// <param name="name">The name of the Villian</param>
        /// <param name="health">The health of the Villian</param>
        /// <param name="attkMax">The attack maximum of the Villian</param>
        /// <param name="blockMax">The block maximum of the Villian</param>
        protected MetaHuman(string name = "SuperHero")
        {
            Name = name;
        }
        #endregion

        /// <summary>
        /// A abstract method that calculates a MetaHuman's attack
        /// </summary>
        /// <returns>The Attack of the MetaHuman</returns>
        public abstract double Attack();

        /// <summary>
        /// A abstract method that calculates a  MetaHuman's block
        /// </summary>
        /// <returns>The Block of the MetaHuman</returns>
        public abstract double Block();

        /// <summary>
        /// A abstract method that sets the health of the MetaHuman
        /// </summary>
        /// <param name="health">The MetaHumans health</param>
        public abstract void SetHealth(double health);

        /// <summary>
        /// A abstract method that will return the health of the metahuman
        /// </summary>
        /// <returns></returns>
        public abstract double GetHealth();

        /// <summary>
        /// A abstract method that sets the battles fought of the MetaHuman
        /// </summary>
        public abstract void SetBattlesFought();

        /// <summary>
        /// A abstract method that will return the battles fought of the metahuman
        /// </summary>
        /// <returns></returns>
        public abstract int GetBattlesFought();

        /// <summary>
        /// A abstract method that zero out the number of battles a MetaHuman has fought
        /// </summary>
        public abstract void ZeroBattle();
    }
}
