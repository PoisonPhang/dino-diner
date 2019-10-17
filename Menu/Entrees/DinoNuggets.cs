/*
 * DinoNuggets.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Dino Nuggets entree item
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// private ingredients list of the Dino Nuggets
        /// </summary>
        private List<string> ingredients;

        /// <summary>
        /// Ingredients of the Dino Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>();
                foreach(string s in ingredients)
                {
                    i.Add(s);
                }
                return i;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (ingredients.Count > 6)
                {
                    special.Add($"Add {ingredients.Count - 6} Chicken Nugget(s)");
                }

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new DinoNugget
        /// </summary>
        public DinoNuggets()
        {
            ingredients = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        /// <summary>
        /// Adds a Dino Nugget to this instance
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
