using System;
namespace ISP
{
    public class Music : File, IListenable
    {
        public int vocalist { get; set; }

        public void listen(){

            Console.WriteLine($"Listen music {name}");
        }
    }
}