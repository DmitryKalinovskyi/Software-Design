using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public void Open()
        {
            Console.WriteLine("Opened balaxy ebook");
        }
    }
}
