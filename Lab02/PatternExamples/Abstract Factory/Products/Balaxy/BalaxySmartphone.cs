﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        private void ShowBalaxyLogo()
        {
            Console.WriteLine("Balaxy logo.");
        }

        public void TurnOn()
        {
            ShowBalaxyLogo();
        }
    }
}
