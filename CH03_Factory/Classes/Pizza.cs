using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;

namespace CH03_Factory.Classes
{
    public abstract class Pizza : IPizza
    {        
        public IDough _dough;
        public ISauce _sauce;
        public IVeggies[] _veggies;
        public ICheese _cheese;
        public IPepperoni _pepperoni;
        public IClams _clam;

        public String Name { get; set; }
        
        
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350\n");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices\n");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box\n");
        }

        public abstract void Prepare();

    }
}
