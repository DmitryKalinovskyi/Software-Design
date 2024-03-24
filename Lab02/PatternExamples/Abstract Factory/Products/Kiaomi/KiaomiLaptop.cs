using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Kiaomi
{
    public class KiaomiLaptop : ILaptop
    {
        public void StartOs()
        {
            Console.WriteLine("Turn on the camera (secretly)");
            Console.WriteLine("Turn on the micro (secretly)");
            Console.WriteLine("Kiaomi desktop is started.");
            Console.WriteLine("Send video/audio package to the KiaomiService or save in tmp");
        }
    }
}
