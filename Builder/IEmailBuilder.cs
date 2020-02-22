namespace Builder
{
    interface IEmailBuilder
    {
        EmailBuilder to(string adress);

        EmailBuilder from(string adress);

        EmailBuilder subject(string subject);

        EmailBuilder body(string content);

        Email build();
    }
}