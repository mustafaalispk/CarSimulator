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
                        {
                            Write("Brand: ");
                            // Vi hämtar in brand, lagar reference till brand.
                            string brand = ReadLine();


                            Write("Model: ");
                            string model = ReadLine();


                            Write("Registration number: ");
                            string registrationNumber = ReadLine();


                            // Här vi skickar in reference till brand, reference till model
                            // inne i Car.
                            Car newCar = new Car(brand, model, registrationNumber);

                            carList[carListCurrentIndexPosition++] = newCar;

                            break;

                        }

                        

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        {
                            string brandHeader = "Brand".PadRight(10, ' ');
                            string modelHeader = "Model".PadRight(10, ' ');
                            string registrationHeader = "Registration number";
                            WriteLine($"{brandHeader} {modelHeader}{registrationHeader}");

                            WriteLine("----------------------------------------------");

                            foreach (Car car in carList)
                            {
                                if (car == null) continue;

                                string brand = car.GetBrand().PadRight(10, ' ');
                                string model = car.GetModel().PadRight(10, ' ');
                                string registrationNumber = car.GetRegistrationNumber().PadLeft(10, ' ');

                                Write(brand);
                                Write(model);
                                WriteLine(registrationNumber);
                            }

                            WriteLine("");
                            WriteLine(">>> Press anykey to continue");
                            ReadKey();

                            break;

                        }
                                                
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
