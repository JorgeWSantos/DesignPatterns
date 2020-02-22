using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyABuilder toyABuilder = new ToyABuilder();
            DirectorToy director = new DirectorToy(toyABuilder);
            director.construct();
            Toy toya = director.getToy();
            Console.WriteLine($"body: {toya.body}");
            Console.WriteLine($"head: {toya.head}");
            Console.WriteLine($"limbs: {toya.limbs}");
            Console.WriteLine($"model: {toya.model}");
            Console.WriteLine($"legs: {toya.legs}");

            ToyBBuilder toyBBuilder = new ToyBBuilder();
            DirectorToy directorB = new DirectorToy(toyBBuilder);
            directorB.construct();
            Toy toyb = directorB.getToy();

            Console.WriteLine($"body: {toyb.body}");
            Console.WriteLine($"head: {toyb.head}");
            Console.WriteLine($"limbs: {toyb.limbs}");
            Console.WriteLine($"model: {toyb.model}");
            Console.WriteLine($"legs: {toyb.legs}");
        }
    }
}
