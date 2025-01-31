using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void HoldPeanutButterShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();

            Assert.Contains("Hold Peanut Butter", pbj.Special);
            Assert.Single(pbj.Special);
        }

        [Fact]
        public void HoldJellyrShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();

            Assert.Contains("Hold Jelly", pbj.Special);
            Assert.Single(pbj.Special);
        }

        [Fact]
        public void HoldPBJShouldAddToSpecial()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            pbj.HoldPeanutButter();

            Assert.Contains("Hold Peanut Butter", pbj.Special);
            Assert.Contains("Hold Jelly", pbj.Special);
            Assert.Equal(2, pbj.Special.Length);
        }

        [Fact]
        public void HoldingPBShouldNotifySoecuakChanged()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () => 
            {
                pbj.HoldPeanutButter();
            });
        }
    }

}
