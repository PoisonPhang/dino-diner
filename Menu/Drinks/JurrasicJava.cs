/*
 * JurrasicJava.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// JurrasicJava Drink object
    /// </summary>
    public class JurassicJava : Drink
    {
        private bool decaf = false;

        /// <summary>
        /// Size property of this JurrasicJava instance
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                switch(value)
                {
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Small:
                        this.Price = 0.59;
                        this.Calories = 2;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// If this instance of JurrasicJava should leave room for cream
        /// </summary>
        public bool SpaceForCream { get; private set; }

        /// <summary>
        /// If this inttance of JurrasicJava should be decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Special instructions for JurassicJava
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (SpaceForCream) special.Add("Leave Space For Cream");
                if (Ice) special.Add("Add Ice");
                if (Decaf) special.Add("Make Decaf");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Creates a new instance of JurrasicJava
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.ingredients.AddRange(new List<string>() { "Water", "Coffee" });
            this.size = Size.Small;
            this.Ice = false;
        }

        /// <summary>
        /// Leaves room for cream in this instance of JurrasicJava
        /// </summary>
        public void LeaveSpaceForCream()
        {
            SpaceForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds ice to this intance of JurrasicJava
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            if (Decaf) return $"{size} Decaf Jurassic Java";
            return $"{size} Jurassic Java";
        }
    }
}
