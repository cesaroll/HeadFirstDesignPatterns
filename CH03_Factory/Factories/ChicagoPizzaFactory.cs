using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;
using CH03_Factory.Classes;

namespace CH03_Factory.Factories
{
    class ChicagoPizzaFactory : IPizzaFactory
    {

        public static ChicagoPizzaFactory CreateFactory()
        {
            return new ChicagoPizzaFactory();
        }

        //Creates and Returns Pizza by type
        public IPizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                    
                case "pepperoni":
                    return new PepperoniPizza();

                case "clam":
                    return new ClamPizza();

                case "veggie":
                    return new VeggiePizza();

                default:
                    return new Pizza();
            }
        }

    }
}
