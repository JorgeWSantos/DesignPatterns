using System;
namespace ISP
{
    public class Document : File, IPrintable, IShowable
    {
        public string type { get; set; }

        public void print(){

            Console.WriteLine($"Print document {name}");
        }

        public void show(){

            Console.WriteLine($"Show document {name}");
        }
    }
}