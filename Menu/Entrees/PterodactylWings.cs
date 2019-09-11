using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Menu item for the Pterdactyl Wings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Price of the Pterdactyl Wings
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Calories of the Pterdactyl Wings
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients of the Pterdactyl Wings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new PterdactylWings instance
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
