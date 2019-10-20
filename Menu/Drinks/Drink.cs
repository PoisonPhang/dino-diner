/*
 * Drink.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract drink class for creating drink objects types
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Ingredients backing variable
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Size backing variable
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// Price of the drink
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Calories in the drink
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Ingredients for the drinks
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>();
                foreach (string s in ingredients)
                {
                    i.Add(s);
                }
                return i;
            }
        }

        /// <summary>
        /// Size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// If the drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Discription of drink
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Special instructions for drink
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Update event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Used to send update notification
        /// </summary>
        /// <param name="property"></param>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Removes ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
    }
}
