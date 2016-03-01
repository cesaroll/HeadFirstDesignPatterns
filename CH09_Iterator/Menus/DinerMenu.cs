using System;
using System.Collections;
using CH09_Iterator.Items;
using CH09_Iterator.Menu;

namespace CH09_Iterator.Menus
{
    public class DinerMenu :IMenu
    {
        private const int MaxItems = 6;
        private MenuItem[] MenuItems { get; set; }
        private int _numberOfItems = 0;

        public DinerMenu()
        {
            MenuItems = new MenuItem[MaxItems];

            this.AddItem("Vegetarian BLT", "(Fakin') Bacon with Lettuce & tomato on whole wheat", true, 2.99);
            this.AddItem("BLT", "Bacon with Lettuce & tomato on whole wheat", false, 2.99);
        }

        public void AddItem(String name, String description, bool vegetarian, double price)
        {
            if (_numberOfItems >= MaxItems)
                Console.WriteLine("Sorry, Menu is full! Can't add item to menu");
            else
                MenuItems[_numberOfItems++] = new MenuItem(name, description, vegetarian, price);
        }

        public IEnumerator CreateEnumerator()
        {
            return MenuItems.GetEnumerator();
        }
    }
}