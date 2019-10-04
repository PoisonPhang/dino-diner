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
                    Ingredients.Add(caneSugar);
                }
                else if (Ingredients.Contains(caneSugar))
                {
                    Ingredients.Remove(caneSugar);
                }
            }
        }

        /// <summary>
        /// If this instance of Tyrannotea contains Lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// Creates a new instance of Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Ingredients.AddRange(new List<string>() { "Water", "Tea" });
            this.Size = Size.Small;
            this.Sweet = false;
        }

        /// <summary>
        /// Adds a lemon to this instance of Tyrannotea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }

        public override string ToString()
        {
            if (sweet) return $"{size} Sweet Tyrannotea";
            return $"{size} Tyrannotea";
        }
    }
}
