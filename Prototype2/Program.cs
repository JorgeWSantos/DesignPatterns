using System;

namespace Prototype2
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a primeira instância como Car
            Car car1 = new Car("ES3", "BMW", "2020");

            Car car2 = car1.clone();
            Car car3 = car1.copy();
            car2.brand = "Honda";
            car3.brand = "Hyundai";
            Console.WriteLine($"car1: {car1.model} | {car1.brand} | {car1.year}");
            Console.WriteLine($"car2: {car2.model} | {car2.brand} | {car2.year}");
            Console.WriteLine($"car3: {car3.model} | {car3.brand} | {car3.year}");
        }
    }
}
