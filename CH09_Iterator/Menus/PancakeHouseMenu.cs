using System;
using System.Collections;
using CH09_Iterator.Items;
using CH09_Iterator.Menu;

namespace CH09_Iterator.Menus
{
    public class PancakeHouseMenu : IMenu
    {
        public ArrayList MenuItems { get; set; }

        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();

            this.AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, sausage", false, 2.99);
            this.AddItem("Regular Pancake Breakfast", "Pancakes made with blueberries", true, 3.49);
        }

        public void AddItem(String name, String description, bool vegetarian, double price)
        {
            MenuItems.Add(new MenuItem(name, description, vegetarian, price));
        }

        public IEnumerator CreateEnumerator()
        {
            return MenuItems.GetEnumerator();
        }

    }
}