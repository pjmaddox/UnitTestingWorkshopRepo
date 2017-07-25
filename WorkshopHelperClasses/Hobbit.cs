using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopHelperClasses
{
    public class Hobbit : ICompanion
    {
        private string name;

        public Hobbit(string name)
        {
            this.name = name;
        }

        public string GetCompanionType()
        {
            return "Hobbit";
        }

        public string GetName()
        {
            return name;
        }
    }
}
