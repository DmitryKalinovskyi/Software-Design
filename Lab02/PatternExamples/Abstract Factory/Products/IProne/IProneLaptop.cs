﻿namespace Abstract_Factory.Products.IProne
{
    public class IProneLaptop : ILaptop
    {
        public void StartOs()
        {
            Console.WriteLine("Starting the core.");
            Console.WriteLine("Configuring I/O devices.");
            Console.WriteLine("Welcome to the IProne desktop.");
        }
    }
}
