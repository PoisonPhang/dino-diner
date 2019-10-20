/*
 * CretaceousCombo
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Combo class
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size =  Size.Small;
        private Side side;
        private Drink drink;

        /// <summary>
        /// Event handler for property updates
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies when property updates
        /// </summary>
        /// <param name="property">name of property</param>
        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Entree entree;

        /// <summary>
        /// Entree of combo
        /// </summary>
        public Entree Entree
        {
            get => entree;
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object senter, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }

        /// <summary>
        /// Drink of combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                drink.Size = size;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Side of combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                side.Size = size;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Price of combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Calories of combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Size of combo
        /// </summary>
        public Size Size
        {
            set
            {
                Side.Size = value;
                Drink.Size = value;
                size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Ingredients of combo
        /// </summary>
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

        /// <summary>
        /// Description of combo
        /// </summary>
        public string Description => ToString();

        /// <summary>
        /// Special instructions for combo
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new combo instance
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Drink = new JurassicJava();
            Side = new Fryceritops();
        }

        public override string ToString()
        {
            return $"{Entree.ToString()} Combo";
        }
    }
}
