using System;

namespace CarSimulator.Domain
{
    // abstract innebär att vi inte kan skappa en car. Vi måste skapa class TeslaModel3, Volvo240
    // som ärvar från Car. 
    abstract class Car   
    {
        //public int id;
        private string brand;
        private string model;
        private string registrationNumber;

        public Car(string brand, string model, string registrationNumber)
        {
            this.brand = brand;
            this.model = model;
            // För att hindra mer än 6 teckan, vi anroppar samma method här i konstruktor.
            SetRegistrationNumber(registrationNumber);            
        }

        // private set---> betyder att nånstans inne i method kan vi sätta velocity like Accelerate(int seconds).
        
        // Om vi vill att den ska anroppa inom ärvande klassen då måste
        // vi skriva protected set. Den är inte public fortforande men
        // den kan anroppa från ärvande klassen
        public int Velocity { get; protected set; }

        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }

        public string GetRegistrationNumber()
        {
            
            return registrationNumber;
        }

        public void SetRegistrationNumber(string newRegistrationNumber)
        {
            if (newRegistrationNumber.Length > 6)
            {
                registrationNumber = newRegistrationNumber.Substring(0, 6);
            }
            else
            {
                registrationNumber = newRegistrationNumber;
            }
            
        }

        // Det har jag sagt i den methoden att det är upp till den ärvande klassen
        // själv avgöra vad som händer när Accelerate anroppas.
        public abstract void Accelerate(int seconds);
        
    }    
}
