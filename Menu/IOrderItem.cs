/* IOrderItem.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Generic Order Item type for use in creating an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Description of the order item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special insctructions of the order item
        /// </summary>
        string[] Special { get; }
    }
}
