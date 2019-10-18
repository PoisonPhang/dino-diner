/* Order.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Representation of an order
    /// </summary>
    class Order
    {
        /// <summary>
        /// Items in the current order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Cost of order before tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;

                foreach (IOrderItem item in Items)
                {
                    subtotalCost += item.Price;
                }

                return subtotalCost;
            }
        }

        /// <summary>
        /// Sales tax rate of the order
        /// </summary>
        public double SalesTaxRate { get; protected set; }

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
    }
}
