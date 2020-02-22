using System;

namespace Builder
{
    //product
    public class Email
    {
        public string to { get; set; }
        public string from { get; set; }
        public string subject { get; set; }
        public string body { get; set; }

        public void show(){

            Console.WriteLine(@$"from: {from}\n
                                to: {to}\n
                                subject: {subject}\n
                                content: {body}");
        }
    }
}