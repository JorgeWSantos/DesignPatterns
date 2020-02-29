using System;
namespace SRP
{
    public class DAOProduto : IDAOProduto
    {
        public void adicionar(Produto produto)
        {
            Console.WriteLine(produto.nome);
        }

        public void atualizar(Produto produto)
        {
        }

        public void excluir(Produto produto)
        {
        }

        public void salvar(Produto produto)
        {
        }
    }
}