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
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        private Size size =  Size.Small;
        private Side side;
        private Drink drink;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Entree entree;
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
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                drink.Size = size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Calories");
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

        public string Description => ToString();

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
