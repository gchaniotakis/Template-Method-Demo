using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    class Cornbread : Bread
    {
        public override string Bake(string dough)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Ingredient> GatherIngredients()
        {
            throw new NotImplementedException();
        }

        public override string MixIngredients(IEnumerable<Ingredient> ingredients)
        {
            throw new NotImplementedException();
        }

        public override string Rest(string dough)
        {
            throw new NotImplementedException();
        }

        public override string Slice(string bread)
        {
            throw new NotImplementedException();
        }
    }
}
