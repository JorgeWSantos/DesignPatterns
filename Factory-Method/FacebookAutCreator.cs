namespace Factory_Method
{
    //concrete creator
    public class FacebookAutCreator : Creator
    {
        public Autentication createInstance(){

            return new AutenticationFacebook();
        }
    }
}