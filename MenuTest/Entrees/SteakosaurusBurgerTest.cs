using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        // Correct Description

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        // Correct Special

        [Fact]
        public void ShouldHaveCorrectDefualtSpecial()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();

            Assert.Empty(sb.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();

            Assert.Contains("Hold Bun", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldPickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();

            Assert.Contains("Hold Pickle", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();

            Assert.Contains("Hold Ketchup", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();

            Assert.Contains("Hold Mustard", sb.Special);
            Assert.Single(sb.Special);
        }

        [Fact]
        public void ShouldHaveAllSpecialAfterHoldAll()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            sb.HoldPickle();
            sb.HoldKetchup();
            sb.HoldMustard();

            Assert.Contains("Hold Bun", sb.Special);
            Assert.Contains("Hold Pickle", sb.Special);
            Assert.Contains("Hold Ketchup", sb.Special);
            Assert.Contains("Hold Mustard", sb.Special);
            Assert.Equal(4, sb.Special.Length);
        }
    }
}
