using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public class Bread
    {
        public void Make()
        {
            var ingredients = GatherIngredients();
            var dough = MixIngredients(ingredients);
            var readyDough = Rest(dough);
            var bread = Bake(readyDough);
            var sliced = Slice(bread);

        }
    }
}
