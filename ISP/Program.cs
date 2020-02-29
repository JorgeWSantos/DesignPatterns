using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            File doc = new Document(){name="teste"};
            doc.open();

            Music music = new Music(){name="mySound"};
            music.open();
            music.listen();
        }
    }
}
