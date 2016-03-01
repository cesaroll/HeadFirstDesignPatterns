using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH03_Factory.Interfaces;
using CH03_Factory.Classes.Ingredients;

namespace CH03_Factory.Factories
{
    class NYPizzaIngredientsFactory : IPizzaIgredientFactory
    {

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FreshClams();
        }
    }
}
