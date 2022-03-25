using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaSicilian : PizzaRecipe
    {
        public override string Name => "Sicilian";

        public override Ingredients Ingredients => throw new NotImplementedException("Method is not implemented.");
    }
}
