using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.AircraftSystem
{
    public class CommandCentre
    {
        public List<Runway> Runways { get; set; }
        public List<Aircraft> Aircrafts { get; set; }

        private Dictionary<Aircraft, Runway> _tooked = new();

        public CommandCentre()
        {
            Runways = new();
            Aircrafts = new();
        }

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            Runways = runways.ToList();
            Aircrafts = aircrafts.ToList();
        }

        private object _requestRunwayLock = new();

        public Runway? RequestRunway(Aircraft aircraft)
        {
            lock (_requestRunwayLock)
            {
                Runway? runway = Runways.FirstOrDefault(x => x != null && !x.isBusy, null);

                if (runway != null)
                {
                    _tooked[aircraft] = runway;

                    runway.isBusy = true;
                }

                return runway;
            }
        }

        public void LandedNotify(Aircraft aircraft)
        {
            if (_tooked.ContainsKey(aircraft) == false)
                throw new InvalidOperationException("You can't notify about landing, if you don't even request runway");

            var runway = _tooked[aircraft];
            runway.HighLightRed();
        }

        public void TookOffNotify(Aircraft aircraft)
        {
            if(_tooked.ContainsKey(aircraft) == false)
                throw new InvalidOperationException("You can't notify about took off, if you don't even landed in runway");

            var runway = _tooked[aircraft];
            _tooked.Remove(aircraft);

            runway.isBusy = false;
            runway.HighLightGreen();
        }
    }
}
