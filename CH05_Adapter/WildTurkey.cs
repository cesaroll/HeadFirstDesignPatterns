using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_Adapter
{
    class WildTurkey : ITurkey
    {
        public void Gooble()
        {
            Console.WriteLine("Gooble gooble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a short distance.");
        }
    }
}
