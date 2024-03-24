using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.IProne
{
    public class IProneNetbook : INetbook
    {
        public void OpenNetwork()
        {
            Console.WriteLine("Network configured with speed 100mbit/s.");
        }
    }
}
