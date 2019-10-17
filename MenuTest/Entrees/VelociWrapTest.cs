using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        // Correct Description

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();

            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        // Correct Special

        [Fact]
        public void ShouldHaveCorrectDefualtSpecial()
        {
            VelociWrap vw = new VelociWrap();

            Assert.Empty(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();

            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();

            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialAfterHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();

            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Single(vw.Special);
        }

        [Fact]
        public void ShouldHaveAllSpecialAfterHoldAll()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();

            Assert.Contains("Hold Dressing", vw.Special);
            Assert.Contains("Hold Lettuce", vw.Special);
            Assert.Contains("Hold Cheese", vw.Special);
            Assert.Equal(3, vw.Special.Length);
        }

        // Correct Notify

        [Fact]
        public void ShouldNotifyWhenHoldDressing()
        {
            VelociWrap vw = new VelociWrap();

            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();

            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void ShouldNotifyWhenHoldCheese()
        {
            VelociWrap vw = new VelociWrap();

            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }
    }
}
