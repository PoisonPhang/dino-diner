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
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.Equal(0.59, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.Equal<uint>(2, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.False(jurrasicJava.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.Equal(Size.Small, jurrasicJava.Size);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSpaceForCream()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.False(jurrasicJava.SpaceForCream);
        }

        // The correct price and calories after changing to small, medium, and large sizes

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetSmall()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Small;
            Assert.Equal(0.59, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetMedium()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Medium;
            Assert.Equal(0.99, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSetLarge()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Large;
            Assert.Equal(1.49, jurrasicJava.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetSmall()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Small;
            Assert.Equal<uint>(2, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetMedium()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Medium;
            Assert.Equal<uint>(4, jurrasicJava.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSetLarge()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.Size = Size.Large;
            Assert.Equal<uint>(8, jurrasicJava.Calories);
        }

        // That invoking AddIce() results in the Ice property being true.

        [Fact]
        public void ShouldHaveIceAfterCallingAddIce()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.AddIce();
            Assert.True(jurrasicJava.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.

        [Fact]
        public void ShouldHaveSpaceForCreamAfterCallingLeaveSpaceForCream()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            jurrasicJava.LeaveSpaceForCream();
            Assert.True(jurrasicJava.SpaceForCream);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurassicJava jurrasicJava = new JurassicJava();
            Assert.Contains("Water", jurrasicJava.Ingredients);
            Assert.Contains("Coffee", jurrasicJava.Ingredients);
            Assert.Equal(2, jurrasicJava.Ingredients.Count);
        }

        // description test

        [Fact]
        public void ShouldReturnCorrectDescriptionForSmall()
        {
            JurassicJava jurassicJava = new JurassicJava();
            Size size = Size.Small;
            jurassicJava.Size = size;
            Assert.Equal($"{size} Jurassic Java", jurassicJava.Description);
            jurassicJava.Decaf = true;
            Assert.Equal($"{size} Decaf Jurassic Java", jurassicJava.Description);
        }

        [Fact]
        public void ShouldReturnCorrectDescriptionForMedium()
        {
            JurassicJava jurassicJava = new JurassicJava();
            Size size = Size.Medium;
            jurassicJava.Size = size;
            Assert.Equal($"{size} Jurassic Java", jurassicJava.Description);
            jurassicJava.Decaf = true;
            Assert.Equal($"{size} Decaf Jurassic Java", jurassicJava.Description);
        }

        [Fact]
        public void ShouldReturnCorrectDescriptionForLarge()
        {
            JurassicJava jurassicJava = new JurassicJava();
            Size size = Size.Large;
            jurassicJava.Size = size;
            Assert.Equal($"{size} Jurassic Java", jurassicJava.Description);
            jurassicJava.Decaf = true;
            Assert.Equal($"{size} Decaf Jurassic Java", jurassicJava.Description);
        }
    }
}
