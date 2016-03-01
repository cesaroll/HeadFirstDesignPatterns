using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;

namespace CH03_Factory.Classes
{
    public class CheesePizza : Pizza
    {
        private IPizzaIgredientFactory _ingredientFactory;
        public CheesePizza(IPizzaIgredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;

            Name = "Cheese Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}\n", Name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
        }
    }
}
