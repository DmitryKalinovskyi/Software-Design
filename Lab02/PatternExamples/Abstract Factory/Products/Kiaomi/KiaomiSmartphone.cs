using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Kiaomi
{
    public class KiaomiSmartphone: ISmartphone
    {
        public void Broke()
        {
            Console.WriteLine("I broked.");
        }

        public void TurnOn()
        {
            Broke();
        }
    }
}
