using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopHelperClasses;
using System.Linq;

namespace WorkshopLibrary
{
    public class GandalfTheGrey : IWizard
    {
        private readonly ITavern _tavern;
        private IEnumerable<ICompanion> _currentCompanions;
        public ILocation _currentLocation;
        private IEnumerable<ILocation> _locationsVisited;

        public GandalfTheGrey(ITavern tavern, IEnumerable<ICompanion> existingCompanions)
        {
            _currentCompanions = existingCompanions;
            _currentLocation = new WorldLocation("The Shire");
            _locationsVisited = new List<ILocation>() { _currentLocation };
            _tavern = tavern;
        }

        public void TravelToNewLocation(ILocation destination)
        {
            if (_locationsVisited.FirstOrDefault(x => x.GetName().Equals(destination.GetName())) == null)
            {
                //Location has not been visited
                var temp = _locationsVisited.ToList();
                temp.Add(destination);
                _locationsVisited = temp;
            }

            _currentLocation = destination;
        }

        public ICompanion FindNewCompanion(string companionName)
        {
            return _tavern.FindNewCompanion(companionName);
        }

        public string GetPreviouslyTraveledLocations()
        {
            return String.Join(", ", _locationsVisited.Select(x => x.GetName()));
        }

        public string GatherCompanions()
        {
            return String.Join(", ", _currentCompanions.Select(x => x.GetName()));
        }

        public double GetHumanToHobbitRatio()
        {
            var humanCount = _currentCompanions.Count(x => x.GetCompanionType() == "Human");
            var hobbitCount = _currentCompanions.Count(x => x.GetCompanionType() == "Hobbit");

            if (hobbitCount == 0 || humanCount == 0)
                return 0;

            return humanCount / hobbitCount;
        }

        public int GetCompanionCount()
        {
            return _currentCompanions.Count();
        }
    }
}
