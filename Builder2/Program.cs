using System;

namespace Builder2
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Builder builderMoto = new BuilderMoto();
            Director directorMotoBuilder = new Director(builderMoto);
            Veiculo moto = directorMotoBuilder.construct();
            
            Console.WriteLine("-------");
            Console.WriteLine("moto");
            Console.WriteLine("ano: {0}", moto.ano);
            Console.WriteLine("placa: {0}", moto.placa);
            Console.WriteLine("portas: {0}",moto.portas);
            Console.WriteLine("");

            Builder builderCarro = new BuilderCarro();
            Director directoCarroBuilder = new Director(builderCarro);
            Veiculo carro = directoCarroBuilder.construct();

            Console.WriteLine("-------");
            Console.WriteLine("carro");
            Console.WriteLine("ano: {0}", carro.ano);
            Console.WriteLine("placa: {0}", carro.placa);
            Console.WriteLine("portas: {0}",carro.portas);
            Console.WriteLine("");
        }
    }
}
