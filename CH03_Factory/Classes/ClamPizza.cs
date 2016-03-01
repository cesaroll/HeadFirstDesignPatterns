using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;

namespace CH03_Factory.Classes
{
    class ClamPizza : Pizza
    {
        private IPizzaIgredientFactory _ingredientFactory;
        public ClamPizza(IPizzaIgredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;

            Name = "Clam Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clam = _ingredientFactory.CreateClam();
        }
    }
}
