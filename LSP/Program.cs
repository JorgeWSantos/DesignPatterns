using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new PessoaJuridica(){
                nome = "jorge",
                CNPJ = "112332"
            };

            Pessoa pessoa2 = new PessoaFisica(){
                nome = "jorge",
                CPF = "121"
            };

            Impressao imp = new Impressao();
            imp.imprimir(pessoa);
            Console.WriteLine("-----");
            imp.imprimir(pessoa2);
        }
    }
}
