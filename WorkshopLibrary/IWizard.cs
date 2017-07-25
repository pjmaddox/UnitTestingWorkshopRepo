using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopHelperClasses;

namespace WorkshopLibrary
{
    public interface IWizard
    {
        string GatherCompanions();

        ICompanion FindNewCompanion(string name);
    }
}
