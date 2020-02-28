namespace Builder2
{
    //product
    public class Veiculo
    {
        private string _marca;
        private string _placa;
        private int _ano;
        private string _cor;
        private string _tipo;
        private int _portas;

        public string marca{ get{ return _marca; } set{_marca = value; } }
        public string placa{ get{ return _placa; } set{_placa = value; } }
        public int ano{ get{ return _ano; } set{_ano = value; } }
        public string cor{ get{ return _cor; } set{_cor = value; } }
        public string tipo{ get{ return _tipo; } set{_tipo = value; } }
        public int portas{ get{ return _portas; } set{_portas = value; } }
    }
}