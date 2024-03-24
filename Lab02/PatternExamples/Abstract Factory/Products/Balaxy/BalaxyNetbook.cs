using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxyNetbook : INetbook
    {
        public void OpenNetwork()
        {
            Console.WriteLine("Looking for the netowork port.");
            Console.WriteLine("Connected to network successfully.");
        }
    }
}
