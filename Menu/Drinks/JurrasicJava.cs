using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// JurrasicJava Drink object
    /// </summary>
    class JurrasicJava : Drink
    {
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
            }
        }

        /// <summary>
        /// If this instance of JurrasicJava should leave room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// If this inttance of JurrasicJava should be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Creates a new instance of JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ingredients.AddRange(new List<string>() { "Water", "Coffe" });
            this.size = Size.Small;
            this.Ice = false;
        }

        /// <summary>
        /// Leaves room for cream in this instance of JurrasicJava
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Adds ice to this intance of JurrasicJava
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
