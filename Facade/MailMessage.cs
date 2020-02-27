namespace Facade
{
    public class MailMessage
    {
        private MailFormat format;
        private string _message;

        public string message{

            get{return _message;}
            set{_message = value;}
        }

        public MailMessage(MailFormat format){

            this.format = format;
        }

        public string getMessage(){
            
            return message;
        }
    }
}