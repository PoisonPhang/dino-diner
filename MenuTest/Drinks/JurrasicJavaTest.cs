/*
 * JurrasicJavaTest.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.Equal(0.59, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.Equal<uint>(2, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.False(jurrasicJava.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.Equal(Size.Small, jurrasicJava.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.False(jurrasicJava.SpaceForCream);
        }

        // The correct price and calories after changing to small, medium, and large sizes

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetSmall()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Small;
            Assert.Equal(0.59, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetMedium()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Medium;
            Assert.Equal(0.99, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetLarge()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Large;
            Assert.Equal(1.49, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetSmall()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Small;
            Assert.Equal<uint>(2, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetMedium()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Medium;
            Assert.Equal<uint>(4, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetLarge()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.Size = Size.Large;
            Assert.Equal<uint>(8, jurrasicJava.Calories);
        }

        // That invoking AddIce() results in the Ice property being true.

        [Fact]
        public void ShouldHaveIceAfterCallingAddIce()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.AddIce();
            Assert.True(jurrasicJava.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.

        [Fact]
        public void ShouldHaveSpaceForCreamAfterCallingLeaveSpaceForCream()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            jurrasicJava.LeaveSpaceForCream();
            Assert.True(jurrasicJava.SpaceForCream);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurrasicJava jurrasicJava = new JurrasicJava();
            Assert.Contains("Water", jurrasicJava.Ingredients);
            Assert.Contains("Coffee", jurrasicJava.Ingredients);
            Assert.Equal(2, jurrasicJava.Ingredients.Count);
        }
    }
}
