using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Factories;
using CH03_Factory.Interfaces;

namespace CH03_Factory.Classes
{
    public class NYPizzaStore : PizzaStore
    {

        public override IPizza CreatePizza(PizzaType pizzaType)
        {
            IPizzaIgredientFactory ingredientFactory = new NYPizzaIngredientsFactory();

            Pizza pizza = null;

            switch (pizzaType)
            {
                case PizzaType.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;

                case PizzaType.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "New York Style Veggie Pizza";
                    break;

                case PizzaType.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;

                case PizzaType.Veggie:
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
            }

            return pizza;

        }
    }
}
