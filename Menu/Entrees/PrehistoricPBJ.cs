﻿/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Connor Davis
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// PrehistoricPBJ Menu item
    /// </summary>
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Ingredients of PrehistoricPBJ
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Special instructions for PrehistoricPBJ
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new instance of PrehistoricPBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Holds peanutbutter for instance of PrehistoricPBJ
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Holds jelly for instance of PrehistoricPBJ
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Returns the name of Prehistoric PB&J as a string
        /// </summary>
        /// <returns>the name of Prehistoric PB&J as a string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
