using System;
using System.Collections;
using System.Security.Cryptography;

namespace CH09_xComponent.Composite
{
    public abstract class MenuComponent
    {
        #region Properties
        public virtual String Name
        {
            get { throw new NotSupportedException(); }
            protected set { throw new NotSupportedException(); }
        }

        public virtual String Description
        {
            get { throw new NotSupportedException(); }
            protected set { throw new NotSupportedException(); }
        }

        public virtual Boolean IsVegetarian
        {
            get { throw new NotSupportedException(); }
            protected set { throw new NotSupportedException(); }
        }

        public virtual Double Price
        {
            get { throw new NotSupportedException(); }
            protected set { throw new NotSupportedException(); }
        }
        #endregion

        #region Methods
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator CreatEnumerator()
        {
            throw new NotSupportedException();
        }

        #endregion

    }
}