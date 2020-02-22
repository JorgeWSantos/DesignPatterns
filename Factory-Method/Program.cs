using System;
using System.Collections.Generic;

namespace Factory_Method
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            List<Creator> auts = new List<Creator>();

            Creator autFacebook = new FacebookAutCreator();
            Creator autGoogle = new GoogleAutCreator();
            auts.Add(autFacebook);
            auts.Add(autGoogle);
            foreach (var autentication in auts)
            {
                Autentication instance = autentication.createInstance();
                instance.autenticar();
            }
        }
    }
}
