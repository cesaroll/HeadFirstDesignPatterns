using System.Collections;

namespace CH09_xComponent.Composite
{
    public class CompositeIterator : IEnumerator
    {
        private Stack _stack;
        public CompositeIterator(IEnumerator enumerator)
        {
            _stack = new Stack();
            _stack.Push(enumerator);
        }

        /// <summary>
        ///  Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_stack == null || _stack.Count == 0)
                return false;
            else
            {
                IEnumerator enumerator = (IEnumerator)_stack.Peek();

                if (enumerator.MoveNext())
                    return true;
                else
                {
                    _stack.Pop();
                    return MoveNext();
                }

            }
        }

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        public object Current
        {
            get
            {
                if(_stack == null || _stack.Count == 0)
                    return null;
                else
                {
                    IEnumerator enumerator = (IEnumerator)_stack.Peek();
                    MenuComponent component = (MenuComponent)enumerator.Current;

                    if (component is Menu)
                        _stack.Push(component.CreatEnumerator());

                    return component;
                }
            }
            private set{ }
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}