namespace Builder
{
    //concrete builder
    public class EmailBuilder : IEmailBuilder
    {
        private Email email;

        public EmailBuilder()
        {
            this.email = new Email();
        }

        public EmailBuilder to(string adress){
            email.to = adress;
            return this;
        }

        public EmailBuilder from(string adress){
            email.from = adress;
            return this;
        }

        public EmailBuilder subject(string subject){
            email.subject = subject;
            return this;
        }

        public EmailBuilder body(string content){

            email.body = content;
            return this;
        }

        public Email build(){

            return email;
        }
    }
}