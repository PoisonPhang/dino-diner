﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();

        public List<IMenuItem> menuItems;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> catigory { get; set; } = new List<string>();

        [BindProperty]
        public double? minimumPrice { get; set; }

        [BindProperty]
        public double? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredientExclusions { get; set; } = new List<string>();

        public bool displayCombos = true;
        public bool displayEntrees = true;
        public bool displayDrinks = true;
        public bool displaySides = true;

        public void OnGet()
        {
            menuItems = Menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            if (catigory.Count > 0)
            {
                if (!catigory.Contains("combo")) displayCombos = false;
                if (!catigory.Contains("entree")) displayEntrees = false;
                if (!catigory.Contains("drink")) displayDrinks = false;
                if (!catigory.Contains("side")) displaySides = false;
            }

            menuItems = Menu.AvailableMenuItems;
            if (search != null) FilterName();
            if (minimumPrice != null || maximumPrice != null) FilterPrice();
            if (ingredientExclusions.Count > 0) FilterIngredintants();
        }

        private void FilterName()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();

            foreach(IMenuItem item in this.menuItems) 
            {
                if (item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase)) menuItems.Add(item);
            }

            this.menuItems = menuItems;
        }

        private void FilterPrice()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();

            double? price;

            if (minimumPrice != null && maximumPrice != null)
            {
                foreach (IMenuItem item in this.menuItems)
                {
                    price = item.Price;
                    if (price >= minimumPrice && price <= maximumPrice) menuItems.Add(item);
                }
            } 
            else if (minimumPrice != null)
            {
                foreach (IMenuItem item in this.menuItems)
                {
                    price = item.Price;
                    if (price >= minimumPrice) menuItems.Add(item);
                }
            } 
            else if (maximumPrice != null)
            {
                foreach (IMenuItem item in this.menuItems)
                {
                    price = item.Price;
                    if (price <= maximumPrice) menuItems.Add(item);
                }
            }

            this.menuItems = menuItems;
        }

        private void FilterIngredintants()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>();

            bool itemFlag;

            foreach(IMenuItem item in this.menuItems)
            {
                itemFlag = true;
                foreach(string ing in ingredientExclusions)
                {
                    if (item.Ingredients.Contains(ing)) itemFlag = false;
                }
                if (itemFlag) menuItems.Add(item);
            }

            this.menuItems = menuItems;
        }
    }
}