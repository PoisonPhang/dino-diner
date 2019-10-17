using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        // Correct Description

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            Brontowurst bw = new Brontowurst();

            Assert.Equal("Brontowurst", bw.Description);
        }

        // Correct Special

        [Fact]
        public void ShouldHaveEmptySpecialDefualt()
        {
            Brontowurst bw = new Brontowurst();

            Assert.Empty(bw.Special);
        }

        [Fact]
        public void SpecialShouldHaveHoldBunWhenHoldBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();

            Assert.Contains("Hold Bun", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void SpecialShouldHaveHoldPeppersWhenHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();

            Assert.Contains("Hold Peppers", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void SpecialShouldHaveHoldOnionsWhenHoldOnions()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();

            Assert.Contains("Hold Onion", bw.Special);
            Assert.Single(bw.Special);
        }

        [Fact]
        public void SpecialShouldContainAllThreeWhenHoldAll()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnion();

            Assert.Contains("Hold Bun", bw.Special);
            Assert.Contains("Hold Peppers", bw.Special);
            Assert.Contains("Hold Onion", bw.Special);
            Assert.Equal(3, bw.Special.Length);
        }

        // Notifies on property change

        [Fact]
        public void ShouldUpdateSpecialWhenHoldBun()
        {
            Brontowurst bw = new Brontowurst();

            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();

            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
        }

        [Fact]
        public void ShouldUpdateSpecialWhenHoldOnion()
        {
            Brontowurst bw = new Brontowurst();

            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
        }
    }

}
