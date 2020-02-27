namespace Facade
{
    //Façade
    public class Email
    {
        private Mail mail;
        private MailFormat format;
        private SMTPSettings settings;
        private MailMessage mailMessage;

        public Email()
        {
            this.format = new MailFormatTxt();
            this.settings = new SMTPSettings(){
                serverName = "gmail",
                password = "123",
                userName = "jorge"
            };
            this.mail = new Mail(this.settings);
            this.mailMessage = new MailMessage(this.format);
        }
        public void enviar(string mensagem){
            mailMessage.message = mensagem;
            this.mail.send(mailMessage);
        }
    }
}