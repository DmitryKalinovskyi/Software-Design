using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.AircraftSystem
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool isBusy = false;

        //public bool CheckIsActive()
        //{
        //    bool result = false;
        //    if (this.IsBusyWithAircraft != null)
        //    {
        //        result = this.IsBusyWithAircraft.IsTakingOff;
        //    }
        //    return result;
        //}

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
