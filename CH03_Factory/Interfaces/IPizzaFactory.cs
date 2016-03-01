using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_Factory.Interfaces
{
    interface IPizzaFactory
    {
        IPizza CreatePizza(string pizzaType);
    }
}
