namespace Prototype
{
    //prototype concrete
    public class Livro : Item
    {
        public Livro(int id, string descricao, string preco)
        :base(id, descricao, preco)
        {
            
        }
        public override Item clone(){
            
            return (Item)this.MemberwiseClone();
        }
    }
}