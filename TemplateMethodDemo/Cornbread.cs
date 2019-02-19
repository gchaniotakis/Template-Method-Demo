using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    class Cornbread : Bread
    {
        private IEnumerable<Ingredient> _ingredients;
        public override string Bake(string dough)
        {
            return $"{dough} is bakng at 180 degrees for 30' "
  
        }

        public override IEnumerable<Ingredient> GatherIngredients()
        {
            return new[]
  {
                new Ingredient("Corn flour"),
                new Ingredient("Yeast"),
                new Ingredient ("Salt"),
                return _ingredients;

            }
        }

        public override string MixIngredients(IEnumerable<Ingredient> ingredients)
        {
            return $"({string.Join(",", _ingredients)})"; 
        }

        public override string Rest(string dough)
        {
            return $"{dough} is resting for 5'";
        }

        public override string Slice(string bread)
        {
            return $"{bread} is Sliced at 1 cm.";
        }
    }
}
