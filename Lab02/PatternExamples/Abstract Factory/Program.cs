using Abstract_Factory.Factories;
using Abstract_Factory.Products;

void TestFactory(ITechFactory factory)
{
    IEBook eBook = factory.CreateEBook();
    ILaptop laptop = factory.CreateLaptop();   
    INetbook netbook = factory.CreateNetbook();
    ISmartphone smartphone = factory.CreateSmartphone();

    // testing features of each product.
    Console.WriteLine("EBook open test:");
    eBook.Open();
    Console.WriteLine();

    Console.WriteLine("Laptop startup test:");
    laptop.StartOs();
    Console.WriteLine();

    Console.WriteLine("Netbook open network test:");
    netbook.OpenNetwork();
    Console.WriteLine();

    Console.WriteLine("Smartphone turn on test:");
    smartphone.TurnOn();
    Console.WriteLine();
}

Console.WriteLine("IProne factory test.");
TestFactory(new IProneTechFactory());
Console.WriteLine();

Console.WriteLine("Balaxy factory test.");
TestFactory(new BalaxyTechFactory());
Console.WriteLine();

Console.WriteLine("Kiaomi factory test.");
TestFactory(new KiaomiTechFactory());
Console.WriteLine();
