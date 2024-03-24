using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.IProne
{
    public class IProneEBook : IEBook
    {
        public void Open()
        {
            Console.WriteLine("IProne ebook running..");
            Console.WriteLine("Ok!..");
        }
    }
}
