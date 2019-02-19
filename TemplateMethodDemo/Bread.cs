using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

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

            Console.WriteLine(sliced);

            //Slice(Bake(Rest(MixIngredients(GathersIngredients()))));
        }

        public abstract IEnumerable<Ingredient> GatherIngredients();

        public abstract string MixIngredients(IEnumerable<Ingredient> ingredients);

        public abstract string Rest(string dough);

        public abstract string Bake(string dough);

        public abstract string Slice(string bread);
    }
}