using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The ability to set each possible flavor

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus sodasaurus = new Sodasaurus();
            sodasaurus.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal(SodasaurusFlavor.Cherry, sodasaurus.Flavor); // Specifying type in expected value negates the need for template call
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

    }
}
