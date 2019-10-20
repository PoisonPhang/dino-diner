/*
 * VelociWrap.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu item for the Veloci Wrap
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// Ingredients of the the the Veloci Wrap
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                return ingredients;
            }
        }

        /// <summary>
        /// Special instrunctions for VelociWrap
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new VelociWrap instance
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Removes dressing from this instance of the VelociWrap
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the lettuce from this instance of the VelociWrap
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the cheese from this instance of the VelociWrap
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
