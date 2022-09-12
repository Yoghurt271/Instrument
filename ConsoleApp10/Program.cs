using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] instruments = new Instrument[] { new Gitar(6), new Drum(5), new Pipe(4) };
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].play();
            }
        }
    }
}
