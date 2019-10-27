/* OrderTest.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        class MockEntree : Entree
        {
            public override List<string> Ingredients => new List<string>() { "MockBun", "MockMeat" };

            public override string[] Special => new string[0];

            public MockEntree()
            {
                Price = 5.49;
                Calories = 300;
            }
        }

        class MockNegativeEntree : Entree
        {
            public override List<string> Ingredients => new List<string>() { "MockBun", "MockMeat" };

            public override string[] Special => new string[0];

            public MockNegativeEntree()
            {
                Price = -40.99;
                Calories = 300;
            }
        }

        class MockDrink : Drink
        {
            public override Size Size
            {
                get => size;
                set => size = value;
            }

            public override string[] Special => new string[0];

            public MockDrink()
            {
                Price = 0.99;
                Calories = 8;
            }
        }

        [Fact]
        public void ShouldCalculateCorrectSubTotalTaxCostAndTotal()
        {
            MockEntree entree = new MockEntree();
            MockDrink drink = new MockDrink();
            Order order = new Order();

            order.Add(entree);
            order.Add(drink);
            order.SalesTaxRate = 0.05;

            Assert.Equal(6.48, order.SubtotalCost, 2);
            Assert.Equal(0.324, order.SalesTaxCost, 2);
            Assert.Equal(6.804, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldNotGoNegative()
        {
            MockNegativeEntree negativeEntree = new MockNegativeEntree();
            Order order = new Order();

            order.Add(negativeEntree);

            Assert.True(order.TotalCost >= 0);
        }
    }
}
