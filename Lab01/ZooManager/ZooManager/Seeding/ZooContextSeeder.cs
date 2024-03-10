using System.Text;
using ZooManagerLibrary.Core;
using ZooManagerLibrary.Entities;

namespace ZooManager.Seeding
{
    public class ZooContextSeeder
    {
        public static void Seed(ZooContext context)
        {
            // create sereral animals

            AnimalType varan = new AnimalType("Varan", "Often bites me in farcry 3");
            AnimalType dog = new AnimalType("Fluffy Dog", "Fluffy fluffy doggy.");
            AnimalType cat = new AnimalType("Shotland Cat", "Kind kitty, rubbing me every day (Dmytro)");

            Animal cat1 = new Animal("Fialka", new DateTime(2020, 2, 2), cat);
            Animal dog1 = new Animal("World Eater", new DateTime(2020, 3, 3), dog);
            Animal varan1 = new Animal("Longy", new DateTime(2000, 10, 10), varan);

            // create food for them

            Food food1 = new Food("Nasty doggy", "num num, cruncy crunchy.", 20);
            Food food2 = new Food("Nasty catty", "num num, cruncy crunchy.", 30);
            Food food3 = new Food("Nasty varanny", "num num, cruncy crunchy.", 1); // he bites me often

            // place them into aviaries

            Aviary aviary1 = new Aviary("catty-heaven-1", 200, 200, new List<Animal> { cat1 });
            Aviary aviary2 = new Aviary("varan-nether", 10, 10, new List<Animal> { varan1});
            Aviary aviary3 = new Aviary("doggy-moggy", 100, 100, new List<Animal> { dog1});


            // create worker
            ZooWorker zooWorker = new ZooWorker("Dmytro", "Kalinovskyi", "Writing code");

            // add all to the context
            context.Aviaries.AddRange(new List<Aviary>() { aviary1, aviary2, aviary3});
            
            context.Foods.AddRange(new List<Food>() { food1, food2, food3});
            
            context.AnimalTypes.AddRange(new List<AnimalType>() { cat, dog, varan});

            context.Animals.AddRange(new List<Animal>() { cat1, dog1, varan1});
        }
    }
}
