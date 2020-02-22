namespace Prototype
{
    //prototype
    public abstract class Item
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string preco { get; set; }
        
        public Item(int id, string descricao, string preco){

            this.id = id;
            this.descricao = descricao;
            this.preco = preco;
        }

        //clonar
        public abstract Item clone();
    }
}