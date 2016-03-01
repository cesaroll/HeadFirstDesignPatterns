using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_Adapter
{
    class DuckTestDrive
    {
        static void Main(string[] args)
        {
            //ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(new WildTurkey());

            TestDuck(turkeyAdapter);

        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
