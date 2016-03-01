using System;
using System.Collections;

namespace CH09_xComponent.Composite
{
    public class Menu : MenuComponent
    {
        private ArrayList MenuComponents { get; set; }
        private IEnumerator _enumerator = null;
        public override String Name { get; protected set; }
        public override String Description { get; protected set; }

        public Menu(string name, string description)
        {
            MenuComponents = new ArrayList();

            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent) MenuComponents[i];
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("\n{0}, {1}\n-------------------------\n", Name, Description));

            foreach (MenuComponent menuComponent in MenuComponents)
                menuComponent.Print();
        }

        public override IEnumerator CreatEnumerator()
        {
            return (_enumerator ?? (_enumerator = new CompositeIterator(MenuComponents.GetEnumerator())));
        }
    }
}