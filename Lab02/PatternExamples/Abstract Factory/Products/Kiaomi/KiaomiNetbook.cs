using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Kiaomi
{
    public class KiaomiNetbook : INetbook
    {
        public void OpenNetwork()
        {
            Console.WriteLine("Making view that we are trying to connect to internet");
        }
    }
}
