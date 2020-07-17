namespace CarSimulator.Domain
{
    class Car
    {
        //public int id;
        private string brand;
        private string model;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }

    }    
}
