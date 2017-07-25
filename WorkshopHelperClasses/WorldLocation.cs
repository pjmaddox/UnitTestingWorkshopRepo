using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopHelperClasses
{
    public class WorldLocation : ILocation
    {
        private string _name;

        public WorldLocation(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
