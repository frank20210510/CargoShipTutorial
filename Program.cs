using System;

namespace CargoShipTutorial
{
    class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Ship Ship = new Ship();
            string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to load the ship to its maximum by adding motor cycle,cars," +
                "truck and train cars.A cycle takes 3 units of weight.A car takes 5 units A units.A truck takes 11 units.A train car takes 17 units.";
            Console.WriteLine(WelcomeMessage);
            while (Ship.Capacity != Ship.getShipLoad())
            {
                Console.WriteLine("The ship capacity is" + Ship.Capacity);
                Console.WriteLine("The ship has " + Ship.CycleCount + " motorcycles on board");
                Console.WriteLine("The ship has " + Ship.CarCount + " car on board");
                Console.WriteLine("The ship has " + Ship.TruckCount + " Truck on board");
                Console.WriteLine("The ship has " + Ship.TrainCarCount + " Train Car on board");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The ship currently has" + Ship.getShipLoad() + " total units on board");
                Console.ForegroundColor = ConsoleColor.White;

                int x;
                Console.WriteLine("How many motor cycles would you like to put on the ship");
                x = int.Parse(Console.ReadLine());

                Ship.CycleCount = x;

                Console.WriteLine("How many cars would you like to put on the ship");
                x = int.Parse(Console.ReadLine());

                Ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on the ship");
                x = int.Parse(Console.ReadLine());

                Ship.TruckCount = x;

                Console.WriteLine("How many train cars would you like to put on the ship");
                x = int.Parse(Console.ReadLine());

                Ship.TrainCarCount = x;

                Console.WriteLine("The ship now has " + Ship.getShipLoad() + " total units of weight on board");

                if (Ship.overUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The ship still has room to spare. Load more items.");
                }
                if (Ship.overUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship still is overloaded. Take some items off!");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("you loaded the ship successfully");

            Console.ReadLine();
        }
    }
}
