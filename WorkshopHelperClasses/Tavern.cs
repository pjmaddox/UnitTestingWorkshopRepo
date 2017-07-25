using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopHelperClasses
{
    public class Tavern : ITavern
    {
        public ICompanion FindNewCompanion(string companionName)
        {
            var randomGenerator = new Random();
            if (randomGenerator.Next(0, 2) == 0)
            {
                return new Human(companionName);
            }
            else
            {
                return new Hobbit(companionName);
            }
        }
    }
}
