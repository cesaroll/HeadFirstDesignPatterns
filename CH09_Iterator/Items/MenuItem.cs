using System;

namespace CH09_Iterator.Items
{
    public class MenuItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public bool IsVegetarian { get; set; }
        public Double Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}\n\t{2}", Name, Price, Description);
        }
    }
}