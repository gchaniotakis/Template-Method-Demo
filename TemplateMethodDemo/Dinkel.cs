using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public class Dinkel : Bread
    {
        private IEnumerable<Ingredient> _ingredients;

        public override IEnumerable<Ingredient> GatherIngredients()
        {
            _ingredients = new[]
            {
                new Ingredient("Dinkel flour"),
                new Ingredient("Yeast"),
                new Ingredient("Salt"),
                new Ingredient("Sunflower seeds")
            };
            return _ingredients;
        }

        public override string MixIngredients(IEnumerable<Ingredient> ingredients)
        {
            return $"Mixing ({string.Join(",", _ingredients)})";
        }

        public override string Rest(string dough)
        {
            return $" {dough} resting for 15'";
        }

        public override string Bake(string dough)
        {
            return $" {dough} baking at 190 for 40'";
        }

        public override string Slice(string bread)
        {
            return bread;
        }
    }
}