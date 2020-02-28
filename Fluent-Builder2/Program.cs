using System;

namespace Builder2
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Builder builderMoto = new BuilderMoto();
            Veiculo moto = builderMoto
                                .ComAPlaca("EGF3302")
                                .ComCor("azul")
                                .daMarca("Honda")
                                .doAno(2020)
                                .doTipo("XRE-500")
                                .Build();
            
            Console.WriteLine(moto.ano);
            Console.WriteLine(moto.placa);
            Console.WriteLine(moto.portas);

            Builder builderCarro = new BuilderCarro();
            Veiculo carro = builderCarro
                                .totalDePortas(4)
                                .daMarca("Hyunday")
                                .Build();
            Console.WriteLine(carro.portas);
            Console.WriteLine(carro.marca);
            Console.WriteLine(carro.ano);


        }
    }
}
