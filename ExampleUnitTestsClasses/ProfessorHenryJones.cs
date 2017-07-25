using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUnitTestsClasses
{
    public class ProfessorHenryJones : IComrade
    {
        public void BeUseful()
        {
            throw new NotImplementedException();
        }

        public IWeapon GiveWeapon()
        {
            return new Whip();
        }

        public void SayCatchPhrase()
        {
            Console.WriteLine();
        }
    }
}
