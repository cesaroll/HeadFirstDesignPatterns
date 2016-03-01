using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Classes;
using CH03_Factory.Factories;
using CH03_Factory.Interfaces;

namespace CH03_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaStore nyPizzaStore = new NYPizzaStore();


            nyPizzaStore.OrderPizza(PizzaType.Cheese);

        }
    }
}
