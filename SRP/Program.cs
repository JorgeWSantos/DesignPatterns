using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(){
                nome = "celular"
            };
            IDAOProduto dao = new DAOProduto();
            dao.adicionar(produto);


        }
    }
}
