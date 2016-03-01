using System.Collections;

namespace CH09_Iterator.Menu
{
    public interface IMenu
    {
        IEnumerator CreateEnumerator();
    }
}