/*
 * Side.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        protected List<string> ingredients = new List<string>();
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

        public string Description => ToString();

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
