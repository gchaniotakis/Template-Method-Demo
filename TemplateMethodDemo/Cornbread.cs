using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    class Cornbread : Bread
    {
        private IEnumerable<Ingredient> _ingredients;

        public override IEnumerable<Ingredient> GatherIngredients()
        {
            _ingredients = new[]
            {
                new Ingredient("Corn flour"),
                new Ingredient("Yeast"),
                new Ingredient("Salt")
            };
            return _ingredients;
        }

        public override string MixIngredients(IEnumerable<Ingredient> ingredients)
        {
            return $"Mixing ({string.Join(",", _ingredients)})";
        }

        public override string Rest(string dough)
        {
            return $" {dough} resting for 5'";
        }

        public override string Bake(string dough)
        {
            return $" {dough} baking at 180 for 30'";
        }

        public override string Slice(string bread)
        {
            return $" {bread} sliced at 1cm";
        }
    }
}
