using System;
namespace ISP
{
    public class Photo : File, IShowable
    {
        public string resolution { get; set; }

        public void show(){

            Console.WriteLine($"Show photo {name}");
        }
    }
}