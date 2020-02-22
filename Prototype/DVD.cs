namespace Prototype
{
    //prototype concrete
    public class DVD : Item
    {
        public DVD(int id, string descricao, string preco)
        :base(id, descricao, preco)
        {
            
        }
        public override Item clone(){
            
            return (Item)this.MemberwiseClone();
        }
    }
}