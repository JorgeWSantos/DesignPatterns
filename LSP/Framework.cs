using System.Collections.Generic;
using System;

namespace LSP
{
    public class Pessoa 
    {
        public string nome { get; set; }

        public virtual List<String> dados(){

            List<string> dados = new List<string>();
            dados.Add(nome);
            return dados;
        }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ {get; set;}
        public override List<string> dados(){

            List<string> dados = base.dados();
            dados.Add(CNPJ);
            return dados;
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

        public override List<string> dados(){
            
            List<string> dados = base.dados();
            dados.Add(CPF);
            return dados;
        }
    }

    public class Impressao
    {
        public void imprimir(Pessoa pessoa){

            foreach (var dado in pessoa.dados())
            {
                Console.WriteLine(dado);
            }
        }
    }
}