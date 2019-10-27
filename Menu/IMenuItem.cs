/* IMenuItem.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Generic menu item interface
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price of the menu item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories of the menu item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Ingredients in the menu item
        /// </summary>
        List<string> Ingredients { get; }
    }
}
