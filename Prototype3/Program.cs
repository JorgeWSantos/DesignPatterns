using System;

namespace Prototype3
{
    class Program
    {
        static void Main(string[] args)
        {

            Color colorRed = new Color(20,2,2);
            Color colorGreen = new Color(2,20,2);
            Color colorBlue = new Color(2,2,20);
            Color newColor = colorRed.clone();
            Console.WriteLine(newColor.red);
            Console.WriteLine(newColor.blue);
        }
    }
}
