using System;
namespace ISP
{
    public abstract class File : IFile
    {
        public string name { get; set; }
        public int tamanho { get; set; }

        public void close()
        {
            Console.WriteLine($"File close {name}");
        }

        public void open()
        {
            Console.WriteLine($"File open {name}");
        }
    }
}