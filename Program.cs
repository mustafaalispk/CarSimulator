using CarSimulator.Domain;
using System;
using System.Threading;
using static System.Console;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldNotExit = true;

            //carlist är en Array av Car. Den kan  peka på en samling av 10 stycken reference till Car.
            Car[] carList = new Car[10];

            uint carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Simulate speed");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:


                        Write("Brand: ");
                        // Vi hämtar in brand, lagar reference till brand.
                        string brand = ReadLine();


                        Write("Model: ");
                        string model = ReadLine();
                       
                        // Här vi skickar in reference till brand, reference till model
                        // inne i Car.
                        Car newCar = new Car(brand, model);                        

                       carList[carListCurrentIndexPosition++] = newCar;

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        WriteLine("Brand             Model");
                        WriteLine("-------------------------");

                        foreach (Car car in carList)
                        {
                            if (car == null) continue;

                            WriteLine($"{car.GetBrand()}           {car.GetModel()}");
                        }

                        WriteLine(">>> Press anykey to continue");
                        ReadKey();

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }
        }

        
    }
}
