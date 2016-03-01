using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH03_Factory.Interfaces
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }

    public enum PizzaType
    {
        Cheese,
        Pepperoni,
        Clam,
        Veggie
    };
}
