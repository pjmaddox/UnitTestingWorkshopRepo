using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopHelperClasses
{
    public class Human : ICompanion
    {
        private string name;

        public Human(string name)
        {
            this.name = name;
        }

        public string GetCompanionType()
        {
            return "Human";
        }

        public string GetName()
        {
            return name;
        }
    }
}
