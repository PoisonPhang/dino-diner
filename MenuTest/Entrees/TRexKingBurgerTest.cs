using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        // Correct Description

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        // Correct Special

        [Fact]
        public void ShouldHaveCorrectDefualtSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.Empty(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();

            Assert.Contains("Hold Bun", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();

            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();

            Assert.Contains("Hold Tomato", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();

            Assert.Contains("Hold Onion", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();

            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();

            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();

            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();

            Assert.Contains("Hold Mayo", trex.Special);
            Assert.Single(trex.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldAll()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldMustard();
            trex.HoldMayo();

            Assert.Contains("Hold Bun", trex.Special);
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Contains("Hold Tomato", trex.Special);
            Assert.Contains("Hold Onion", trex.Special);
            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Contains("Hold Mayo", trex.Special);
        }

        // Correct Notify

        [Fact]
        public void ShouldNotifyWhenHoldBun()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldOnion();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldPickle()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();

            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
        }
    }
}
