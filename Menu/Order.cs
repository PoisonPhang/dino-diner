/* Order.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Representation of an order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        double salesTaxRate;
        /// <summary>
        /// Items in the current order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get => items.ToArray();
        }

        /// <summary>
        /// Cost of order before tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;

                foreach (IOrderItem item in items)
                {
                    subtotalCost += item.Price;
                }

                return subtotalCost;
            }
        }

        /// <summary>
        /// Sales tax rate of the order
        /// </summary>
        public double SalesTaxRate {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

            }
        }

        /// <summary>
        /// Cost of the sales tax for the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// Total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                double totalCost = SubtotalCost + SalesTaxCost;

                if (totalCost < 0) return 0;
                return totalCost;
            }
        }

        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
