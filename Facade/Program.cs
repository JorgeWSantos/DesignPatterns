using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.enviar("opa");
        }
    }
}
