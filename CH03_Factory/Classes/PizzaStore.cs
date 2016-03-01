using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;

namespace CH03_Factory.Classes
{
    public abstract class PizzaStore : IPizzaStore
    {

        public IPizza OrderPizza(PizzaType pizzaType)
        {
            IPizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }

        public abstract IPizza CreatePizza(PizzaType pizzaType);
    }
}
