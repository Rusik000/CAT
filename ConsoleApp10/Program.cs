using System;

namespace Cat_House
{
    class Program
    {
        static void Run()
        {
            try
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t Kakadu Pet Shop");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t Royal Canin Petshop");
                Console.ResetColor();

                Cat cat1 = new Cat("Mira", 6, 400, 10, "male");
                Cat cat2 = new Cat("Mestan", 2, 250, 20, "male");
                Cat cat4 = new Cat("Minnosh", 6, 400, 10, "male");
                Cat cat5 = new Cat("Misha", 2, 250, 20, "male");

                CatHouse catHouse = new CatHouse("Kakadu 111");
                catHouse.AddCat(cat1);
                catHouse.AddCat(cat2);

                CatHouse catHouse2 = new CatHouse("Royal 555");
                catHouse2.AddCat(cat4);
                catHouse2.AddCat(cat5);

                Cat cat3 = new Cat("Haykanush", 4, 500, 15, "Female");
                catHouse.AddCat(cat3);


                PetShop petShop = new PetShop();

                petShop.AddCatHouse(catHouse);
                petShop.AddCatHouse(catHouse2);
                petShop.Show();
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Red;
                int Allprice = petShop.GetCatsPriceInTheCatHouses();
                Console.WriteLine($"All Cats Price in Cat Houses: {Allprice} $ ");
                Console.ResetColor();
            }

            catch (InvalidOperationException content)
            {
                Console.WriteLine(content);
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
