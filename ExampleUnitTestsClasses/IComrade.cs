using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUnitTestsClasses
{
    public interface IComrade
    {
        void SayCatchPhrase();

        void BeUseful();

        IWeapon GiveWeapon();
    }
}
