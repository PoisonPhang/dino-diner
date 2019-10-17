/*
 * WaterTest.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, size, and lemon properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false

        [Fact]
        public void ShouldHaveNoIceAfterCallingHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.

        [Fact]
        public void ShouldHaveLemonAfterCallingAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectINgredientsAfterCallingAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains("Water", water.Ingredients);
            Assert.Contains("Lemon", water.Ingredients);
            Assert.Equal(2, water.Ingredients.Count);
        }

        // Correct Description

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldReturnCorrectDescription(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.Description);
        }

        // Correct Special

        [Fact]
        public void ShouldReturnAllSpecialWhenNeeded()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();

            Assert.Contains("Hold Ice", water.Special);
            Assert.Contains("Add Lemon", water.Special);
        }

        [Fact]
        public void ShouldReturnHoldIce()
        {
            Water water = new Water();
            water.HoldIce();

            Assert.Contains("Hold Ice", water.Special);
            Assert.Single(water.Special);
        }

        [Fact]
        public void ShouldReturnAddLemon()
        {
            Water water = new Water();
            water.AddLemon();

            Assert.Contains("Add Lemon", water.Special);
            Assert.Single(water.Special);
        }

        [Fact]
        public void ShouldUpdateSizeWhenSizeChanged()
        {
            Water water = new Water();

            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenAddLemon()
        {
            Water water = new Water();

            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenHoldIce()
        {
            Water water = new Water();

            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }
    }
}
