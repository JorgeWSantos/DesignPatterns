using System;
namespace Facade
{
    public class Mail
    {
        private SMTPSettings config;
        public Mail(SMTPSettings config){

            this.config = config;
        }
        public void send(MailMessage message){

            Console.WriteLine($"enviando mensagem {message.getMessage()}");
        }
    }
}