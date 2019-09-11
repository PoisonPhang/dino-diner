using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Dino Nuggets entree item
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// private ingredients list of the Dino Nuggets
        /// </summary>
        private List<string> ingredients;

        /// <summary>
        /// Price of the Dino Nuggets
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Colories of the Dino Nuggets
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients of the Dino Nuggets
        /// </summary>
        public List<string> Ingredients => ingredients;

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
        }
    }
}
