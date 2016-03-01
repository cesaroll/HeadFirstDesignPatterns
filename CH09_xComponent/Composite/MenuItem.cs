using System;

namespace CH09_xComponent.Composite
{
    public class MenuItem : MenuComponent
    {
        public override String Name { get; protected set; }
        public override String Description { get; protected set; }
        public override bool IsVegetarian { get; protected set; }
        public override Double Price { get; protected set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("   {0}{1}, {2:C2}\n     -- {3}", Name, IsVegetarian? "(v)" : "", Price, Description));
        }
        
    }
}