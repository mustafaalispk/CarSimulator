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
            this.registrationNumber = registrationNumber;
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

    }    
}
