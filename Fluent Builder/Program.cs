using System;

namespace Builder
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new EmailBuilder()
                                .from("Capao Bonito - SP")
                                .to("São Paulo")
                                .subject("Mariano da Silva")
                                .body("conteúdo do texto famoso lorem ipsum")
                                .build();
            email.show();

        }
    }
}
