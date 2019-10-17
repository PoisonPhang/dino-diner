/*
 * Tyrannotea.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea Drink object
    /// </summary>
    public class Tyrannotea : Drink
    {
        private string caneSugar = "Cane Sugar";

        private bool sweet = false;

        /// <summary>
        /// Size property of this instance of Tyrannotea
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
                        this.Price = 1.99;
                        this.Calories = sweet ? (uint) 64 : 32;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = sweet ? (uint) 32 : 16;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = sweet ? (uint) 16 : 8;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
            }
        }

        /// <summary>
        /// If this instance of Tyrannotea contains Cane Sugar for sweetner
        /// </summary>
        public bool Sweet
        {
            get => sweet;
            set
            {
                sweet = value;
                Size = size;
                if (sweet)
                {
                    ingredients.Add(caneSugar);
                }
                else if (Ingredients.Contains(caneSugar))
                {
                    ingredients.Remove(caneSugar);
                }
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// If this instance of Tyrannotea contains Lemon
        /// </summary>
        public bool Lemon { get; set; }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();

                if (!Ice) special.Add("Hold Ice");
                if (Sweet) special.Add("Make Sweet");
                if (Lemon) special.Add("Add Lemon");

                return special.ToArray();
            }
        }

        /// <summary>
        /// Creates a new instance of Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.ingredients.AddRange(new List<string>() { "Water", "Tea" });
            this.Size = Size.Small;
            this.Sweet = false;
        }

        /// <summary>
        /// Adds a lemon to this instance of Tyrannotea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            if (sweet) return $"{size} Sweet Tyrannotea";
            return $"{size} Tyrannotea";
        }
    }
}
