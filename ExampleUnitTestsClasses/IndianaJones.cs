using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleUnitTestsClasses
{
    public class IndianaJones
    {
        private readonly IWeapon _weapon;
        private readonly ITool _tool;
        private readonly IComrade _comrade;

        public IndianaJones(IWeapon weapon, ITool tool, IComrade sideKick)
        {
            _weapon = weapon;
            _tool = tool;
            _comrade = sideKick;
        }


    }
}
