using System;

namespace Factory_Method
{
    //concrete product
    public class AutenticationGoogle : Autentication
    {
        public override void autenticar(){
            
            Console.WriteLine("aut google");
        }
    }
}