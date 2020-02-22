namespace Factory_Method
{
    //concrete creator
    public class GoogleAutCreator : Creator
    {
        public Autentication createInstance()
        {
            return new AutenticationGoogle();
        }
    }
}