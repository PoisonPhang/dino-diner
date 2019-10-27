/* Side.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for Side items
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing field for ingredients
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Backing field for size
        /// </summary>
        protected Size size;

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
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

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Discription of sides
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Special instructions of sides
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Event handler for property changed notification
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies of a property update
        /// </summary>
        /// <param name="property">name of property</param>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
