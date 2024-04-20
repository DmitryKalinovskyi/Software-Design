using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.AircraftSystem
{
    public enum AircraftState
    {
        Landing = 0,
        Landed,
        TakingOff,
        InAir
    }

    public class Aircraft
    {
        public string Name;

        private CommandCentre _commandCentre;
        //public Runway? CurrentRunway { get; set; }

        //public bool IsLanding { get; set; }
        //public bool IsLanded { get; set; }
        //public bool IsTakingOff { get; set; }

        public AircraftState State = AircraftState.InAir;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
        }

        //public Aircraft(string name, int size)
        //{
        //    Name = name;
        //}

        public void Land()
        {
            if (State != AircraftState.InAir)
            {
                Console.WriteLine("You can't land aircraft at this moment");
                return;
            }

            // request free runway.
            Runway? requestedRunway = _commandCentre.RequestRunway(this);

            if (requestedRunway == null)
            {
                Console.WriteLine($"Could not land {Name}, command center don't give runway.");
                return;
            }

            // perform landing
            State = AircraftState.Landing;
            Console.WriteLine($"Aircraft {Name} has landed.");

            State = AircraftState.Landed;

            // notify about landing the commandCentre
            _commandCentre.LandedNotify(this);
        }

        public void TakeOff()
        {
            if (State != AircraftState.Landed)
            {
                Console.WriteLine("You can't take off aircraft at this moment");
                return;
            }

            State = AircraftState.TakingOff;
            Console.WriteLine($"Aircraft {Name} has took off.");
            State = AircraftState.InAir;

            _commandCentre.TookOffNotify(this);
        }

        //public void Land(Runway runway)
        //{
        //    Console.WriteLine($"Aircraft {this.Name} is landing.");
        //    Console.WriteLine($"Checking runway.");
        //    if (runway.IsBusyWithAircraft == null)
        //    {
        //        Console.WriteLine($"Aircraft {this.Name} has landed.");
        //        runway.IsBusyWithAircraft = this;
        //        runway.HighLightRed();
        //        this.CurrentRunway = runway;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Could not land, the runway is busy.");
        //    }
        //}
        //public void TakeOff(Runway runway)
        //{
        //    Console.WriteLine($"Aircraft {this.Name} is taking off.");
        //    runway.IsBusyWithAircraft = null;
        //    this.CurrentRunway = null;
        //    runway.HighLightGreen();
        //    Console.WriteLine($"Aircraft {this.Name} has took off.");
        //}
    }
}
