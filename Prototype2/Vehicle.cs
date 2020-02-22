namespace Prototype2
{
    //prototype
    public abstract class Vehicle
    {
        public string model;
        public string year;
        public string brand;

        public Vehicle(string model, string year, string brand)
        {
            this.model = model;
            this.year = year;
            this.brand = year;
        }

        public abstract Car clone();

        //deep copy
        public abstract Car copy();
    }
}