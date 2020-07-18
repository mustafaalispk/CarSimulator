using System;

namespace CarSimulator.Domain
{
    class Car
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
    }    
}
