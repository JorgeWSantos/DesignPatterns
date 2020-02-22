using System;

namespace Prototype
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro(1, "livro", "50");
            Livro cloneLivro = (Livro)livro.clone();

            Console.WriteLine($"clonado {cloneLivro.descricao}");
        }
    }
}
