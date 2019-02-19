using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public abstract class Bread
    {
        public void Make()
        {
            Console.WriteLine($"Making a {GetType().Name}");
            var ingredients = GatherIngredients();
            var dough = MixIngredients(ingredients);
            var readyDough = Rest(dough);
            var bread = Bake(readyDough);
            var sliced = Slice(bread);

        }

        public abstract IEnumerable<Ingredient> GatherIngredients();

        public abstract string MixIngredients(IEnumerable<Ingredient> ingredients);

        public abstract string Rest(string dough);

        public abstract string Bake(string dough);

        public abstract string Slice(string bread);

        Console.WriteLine(sliced);
            
        
    }
}
