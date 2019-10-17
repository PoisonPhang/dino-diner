/*
 * TyrannoteaTest.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // The correct default price, calories, ice, size, lemon, and sweet properties.

        [Fact]
        public void ShouldHaveTheCorrectDefualtPrice()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.Equal(0.99, tyrannotea.Price);
        }

        [Fact]
        public void ShouldHaveTheCorrectDefaultCalories()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.Equal<uint>(8, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveTheCorrectDefaultIce()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.True(tyrannotea.Ice);
        }

        [Fact]
        public void ShouldHaveTheCorrectDefaultSize()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.Equal(Size.Small, tyrannotea.Size);
        }

        [Fact]
        public void ShouldHaveTheCorrectDefaultLemon()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.False(tyrannotea.Lemon);
        }

        [Fact]
        public void ShouldHaveTheCorrectDefaultSweet()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.False(tyrannotea.Sweet);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetSmall()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Small;
            Assert.Equal(0.99, tyrannotea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetMedium()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Medium;
            Assert.Equal(1.49, tyrannotea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetLarge()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Large;
            Assert.Equal(1.99, tyrannotea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetSmall()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Small;
            Assert.Equal<uint>(8, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetMedium()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Medium;
            Assert.Equal<uint>(16, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetLarge()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Large;
            Assert.Equal<uint>(32, tyrannotea.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveIceBeFalseAfterHoldIce()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.HoldIce();
            Assert.False(tyrannotea.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.

        [Fact]
        public void ShouldHaveLemonBeTrueAfterAddLemon()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.AddLemon();
            Assert.True(tyrannotea.Lemon);
        }

        // That setting the sweet property to true results in the right calories for each size

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetOnSmall()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Small;
            tyrannotea.Sweet = true;
            Assert.Equal<uint>(16, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetOnMedium()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Medium;
            tyrannotea.Sweet = true;
            Assert.Equal<uint>(32, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetOnLarge()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Large;
            tyrannotea.Sweet = true;
            Assert.Equal<uint>(64, tyrannotea.Calories);
        }

        // That setting the sweet property to false (after it has been set to true) results in the right calories for each size.

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetSwapSmall()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Small;
            tyrannotea.Sweet = true;
            tyrannotea.Sweet = false;
            Assert.Equal<uint>(8, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetSwapMedium()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Medium;
            tyrannotea.Sweet = true;
            tyrannotea.Sweet = false;
            Assert.Equal<uint>(16, tyrannotea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSweetSwapLarge()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = Size.Large;
            tyrannotea.Sweet = true;
            tyrannotea.Sweet = false;
            Assert.Equal<uint>(32, tyrannotea.Calories);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectDefualtIngredients()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.Contains("Water", tyrannotea.Ingredients);
            Assert.Contains("Tea", tyrannotea.Ingredients);
            Assert.Equal(2, tyrannotea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsAfterAddLemon()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.AddLemon();
            Assert.Contains("Water", tyrannotea.Ingredients);
            Assert.Contains("Tea", tyrannotea.Ingredients);
            Assert.Contains("Lemon", tyrannotea.Ingredients);
            Assert.Equal(3, tyrannotea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsAfterSweetSetTrue()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Sweet = true;
            Assert.Contains("Water", tyrannotea.Ingredients);
            Assert.Contains("Tea", tyrannotea.Ingredients);
            Assert.Contains("Cane Sugar", tyrannotea.Ingredients);
            Assert.Equal(3, tyrannotea.Ingredients.Count);
        }

        // Correct Description

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void ShouldReturnCorrectDescritpionForAllSizesAndSweetAndUnsweet(Size size, bool isSweet)
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Size = size;
            tyrannotea.Sweet = isSweet;
            if (isSweet) Assert.Equal($"{size} Sweet Tyrannotea", tyrannotea.Description);
            else Assert.Equal($"{size} Tyrannotea", tyrannotea.Description);
        }

        // Correct special values

        [Fact]
        public void ShouldReturnNoSpecialDefualt()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            Assert.Empty(tyrannotea.Special);
        }

        [Fact]
        public void ShouldReturnAllSpecialValuesWhenNeeded()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.HoldIce();
            tyrannotea.Sweet = true;
            tyrannotea.AddLemon();

            Assert.Contains("Hold Ice", tyrannotea.Special);
            Assert.Contains("Make Sweet", tyrannotea.Special);
            Assert.Contains("Add Lemon", tyrannotea.Special);
        }

        [Fact]
        public void ShouldReturnHoldIce()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.HoldIce();

            Assert.Contains("Hold Ice", tyrannotea.Special);
            Assert.Single(tyrannotea.Special);
        }

        [Fact]
        public void ShouldReturnMakeSweet()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.Sweet = true;

            Assert.Contains("Make Sweet", tyrannotea.Special);
            Assert.Single(tyrannotea.Special);
        }

        [Fact]
        public void ShouldReturnAddLemon()
        {
            Tyrannotea tyrannotea = new Tyrannotea();
            tyrannotea.AddLemon();

            Assert.Contains("Add Lemon", tyrannotea.Special);
            Assert.Single(tyrannotea.Special);
        }

        [Fact]
        public void ShouldUpdatePriceWhenSizeChanged()
        {
            Tyrannotea tyrannotea = new Tyrannotea();

            Assert.PropertyChanged(tyrannotea, "Price", () => 
            {
                tyrannotea.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldUpdateSizeWhenSizeChanged()
        {
            Tyrannotea tyrannotea = new Tyrannotea();

            Assert.PropertyChanged(tyrannotea, "Size", () =>
            {
                tyrannotea.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenSweet()
        {
            Tyrannotea tyrannotea = new Tyrannotea();

            Assert.PropertyChanged(tyrannotea, "Special", () =>
            {
                tyrannotea.Sweet = true;
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenAddLemon()
        {
            Tyrannotea tyrannotea = new Tyrannotea();

            Assert.PropertyChanged(tyrannotea, "Special", () =>
            {
                tyrannotea.AddLemon();
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenHoldIce()
        {
            Tyrannotea tyrannotea = new Tyrannotea();

            Assert.PropertyChanged(tyrannotea, "Special", () =>
            {
                tyrannotea.HoldIce();
            });
        }
    }
}
