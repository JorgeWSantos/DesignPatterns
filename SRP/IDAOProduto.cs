namespace SRP
{
    public interface IDAOProduto
    {
        void salvar(Produto produto);

        void excluir(Produto produto);

        void adicionar(Produto produto);

        void atualizar(Produto produto);
    }
}