/*
 * SodasaurusTest.cs
 * Author: Connor Davis
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The ability to set each possible flavor

        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal(SodasaurusFlavor.Cola, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal(SodasaurusFlavor.Orange, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal(SodasaurusFlavor.Vanilla, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal(SodasaurusFlavor.Chocolate, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal(SodasaurusFlavor.RootBeer, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, sodasaurus.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal(SodasaurusFlavor.Lime, sodasaurus.Flavor);
        }

        // The correct default price, calories, ice, and size

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.Equal(1.50, sodasaurus.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.Equal<uint>(112, sodasaurus.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.True(sodasaurus.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.Equal(Size.Small, sodasaurus.Size);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Small;
            Assert.Equal(1.50, sodasaurus.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Medium;
            Assert.Equal(2.00, sodasaurus.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Large;
            Assert.Equal(2.50, sodasaurus.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Small;
            Assert.Equal<uint>(112, sodasaurus.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Medium;
            Assert.Equal<uint>(156, sodasaurus.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = Size.Large;
            Assert.Equal<uint>(208, sodasaurus.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void ShouldHaveIcePropertyReturnFalseAfterCall()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.HoldIce();
            Assert.False(sodasaurus.Ice);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldReturnCorrectIngredients()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            Assert.Contains("Water", sodasaurus.Ingredients);
            Assert.Contains("Natural Flavors", sodasaurus.Ingredients);
            Assert.Contains("Cane Sugar", sodasaurus.Ingredients);
            Assert.Equal(3, sodasaurus.Ingredients.Count);
        }

        // Correct Description

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void ShouldReturnCorrectDescription(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Size = size;
            sodasaurus.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", sodasaurus.Description);
        }

        // Should Return correct special values

        [Fact]
        public void ShouldReturnHoldIce()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.HoldIce();
            Assert.Contains("Hold ice", sodasaurus.Special);
        }
    }
}
