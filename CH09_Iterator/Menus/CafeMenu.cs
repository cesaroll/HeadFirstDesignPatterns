using System;
using System.Collections;
using CH09_Iterator.Items;
using CH09_Iterator.Menu;

namespace CH09_Iterator.Menus
{
    public class CafeMenu : IMenu
    {
        private Hashtable MenuItems { get; set; }

        public CafeMenu()
        {
            MenuItems = new Hashtable();

            this.AddItem("Veggie Burger and Air Fries", "Veggie burguer on a whole wheat bun, lettuce, tomato and fries", true, 3.99);
            this.AddItem("Soup of the Day", "A coup of the soup of the day with a side salad", false, 3.69);
        }

        public void AddItem(String name, String description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem.Name, menuItem);
        }

        public IEnumerator CreateEnumerator()
        {
            return MenuItems.Values.GetEnumerator();
        }
    }

}