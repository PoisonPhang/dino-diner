/*
 * CretaceousCombo
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class CretaceousCombo : IMenuItem
    {
        private Size size =  Size.Small;
        private Side side;
        private Drink drink;

        public Entree Entree { get; set; }
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                drink.Size = size;
            }
        }
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                side.Size = size;
            }
        }
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        public Size Size
        {
            set
            {
                Side.Size = value;
                Drink.Size = value;
                size = value;
            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Drink = new JurrasicJava();
            Side = new Fryceritops();
        }
    }
}
