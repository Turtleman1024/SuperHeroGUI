using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Duel_GUI
{
    /// <summary>
    /// A object the represents a fighter
    /// </summary>
    public class Fight
    {
        private MetaHuman Fighter1;
        private MetaHuman Fighter2;
        private readonly double Fighter1Attack;
        private readonly double Fighter2Block;
        private double Damage;
        private string Result;

        /// <summary>
        /// Constructs a fight
        /// </summary>
        /// <param name="fighter1">The aggressor</param>
        /// <param name="fighter2">The defender</param>
        public Fight(ref MetaHuman fighter1, ref MetaHuman fighter2)
        {
            Fighter1 = fighter1;
            Fighter2 = fighter2;

            Fighter1Attack = fighter1.Attack();
            Fighter2Block = fighter2.Block();

            Damage = 0;
            Result = null;
        }

        /// <summary>
        /// A method that starts a battle and sets the results
        /// </summary>
        public void StartBattle()
        {
            ///Calculater damage done
            Damage = Attack(Fighter1Attack, Fighter2Block);

            ///Fighter2 takes damage
            Fighter2.SetHealth(Fighter2.GetHealth() - Damage);

            ///Set the number of battles fought for fighter1
            Fighter1.SetBattlesFought();

            ///Store results of the attack
            Result = "\n" + Fighter1.Name + " does " + Damage.ToString() + " damage to " + Fighter2.Name + "\n";

        }

        /// <summary>
        /// A method that calculates the damage done 
        /// </summary>
        /// <param name="fighter1_attack">The attackers attack</param>
        /// <param name="fighter2_block">The defenders block</param>
        /// <returns>The attack strength</returns>
        public double Attack(double fighter1_attack, double fighter2_block)
        {
            ///Get the attack strength
            double attack = (fighter1_attack - fighter2_block);

            ///Check if the attack was completely block
            if (attack <= 0)
            {
                return 0;
            }

            ///Damage need to be done return the attack
            return attack;
        }

        /// <summary>
        /// A method that returns the results
        /// </summary>
        /// <returns></returns>
        public string GetResults()
        {
            return Result;
        }


    }
}
