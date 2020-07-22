using CarSimulator.Domain;
using System;
using System.Threading;
using static System.Console;

namespace CarSimulator
{
    class Program
    {
        //carlist är en Array av Car. Den kan  peka på en samling av 10 stycken reference till Car.
        static Car[] carList = new Car[10];
        static void Main(string[] args)
        {
            bool shouldNotExit = true;           

            uint carListCurrentIndexPosition = 0;

            while (shouldNotExit)
            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. Change registration number");
                WriteLine("4. Simulate speed");
                WriteLine("5. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            // Nu behöver vi inte sätta in själv brand, model
                            // nu vill vi välja vilken bil är den istället.
                            // nu har vi en class som reperestera TeslaModel3, Volvo240
                            // så ända behöver vi registration number.

                            Write("Registration number: ");

                            string registrationNumber = ReadLine();

                            WriteLine("Choose Car: ");

                            WriteLine("1. Tesla, Model 3");

                            WriteLine("2. Volvo, 240");

                            keyPressed = ReadKey(true);

                            // Här har vi reference till en bil
                            Car newCar = null;

                            if (keyPressed.Key == ConsoleKey.D1)
                            {
                                
                                // Här vi skickar in reference till brand, reference till model
                                // inne i Car.
                                // Car är föräldrar class till TeslaModel3

                                newCar = new TeslaModel3(registrationNumber);
                               
                            }
                            else if (keyPressed.Key == ConsoleKey.D2)
                            {
                   
                                // Här vi skickar in reference till brand, reference till model
                                // inne i Car.
                                // Car är föräldrar class till Volvo240

                                newCar = new Volvo240(registrationNumber);
                                                                
                            }
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

                        {

                            Write("Previous registration number: ");

                            string previousRegistrationNumber = ReadLine();


                            Write("New registration number: ");

                            string newRegistrationNumber = ReadLine();

                            Clear();

                            // Först ska vi hitta reference till den bilen som har den registration number.

                            Car theCar = SearchCarByRegistrationNumber(previousRegistrationNumber);

                            if (theCar != null)
                            {
                                // Den method SetRegistrationNumber() finns på objektet. Den kommer skapas under Car.
                                theCar.SetRegistrationNumber(newRegistrationNumber);
                            }
                            else
                            {
                                WriteLine("Car not found");

                                Thread.Sleep(2000);
                            }
                        }
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        Write("Seconds: ");

                        int seconds = int.Parse(ReadLine());

                        Clear();

                        WriteLine("Car                  Velocity (km/h)");
                        WriteLine("-------------------------------------------");

                        foreach (var car in carList)
                        {
                            if (car == null) continue;

                            car.Accelerate(seconds);

                            WriteLine($"{car.GetBrand()}, {car.GetModel()}     {car.Velocity}");
                        }
                        ReadKey(true);

                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        shouldNotExit = false;

                        break;
                }

                Clear();
            }
        }

        private static Car SearchCarByRegistrationNumber(string previousRegistrationNumber)
        {
            // Här kommer skapa carReferenceToReturn som  pekar på en bil som kommer faktiskt vi hitta.
            Car carReferenceToReturn = null;

            foreach (Car carReference in carList)
            {                
                
                if (carReference == null) continue;
                 
                // om carReference är inte null då hämtar vi registrationNumber, sen kollar
                // vi om registrationNumber är lika med previousRegistrationNumber.
                if (carReference.GetRegistrationNumber() == previousRegistrationNumber)
                {
                    // Sen kopiorer vi carReference till carReferenceToReturn.
                    carReferenceToReturn = carReference;                    
                    break;
                }                
            }
            return carReferenceToReturn;
        }
    }
}
