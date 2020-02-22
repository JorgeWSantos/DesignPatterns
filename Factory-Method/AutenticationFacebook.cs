using System;

namespace Factory_Method
{
    //concrete product
    public class AutenticationFacebook : Autentication
    {
        public override void autenticar(){

            Console.WriteLine("Facebook aut");
        }
    }
}