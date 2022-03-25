using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaPeperoni : PizzaRecipe
    {
        public override string Name => "Peperoni";

        public override Ingredients Ingredients => throw new NotImplementedException("Method is not implemented.");
    }
}
