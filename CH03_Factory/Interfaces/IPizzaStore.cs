using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_Factory.Interfaces
{
    public interface IPizzaStore
    {
        IPizza OrderPizza(PizzaType pizzaType);
        IPizza CreatePizza(PizzaType pizzaType);
    }
    
}
