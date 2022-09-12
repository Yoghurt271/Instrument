    using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Drum : Instrument
    {
        int Size;
        public Drum(int Size)
        {
            this.Size = Size;
        }

        public void play()
        {
            Console.WriteLine($"Играет барабан, размером {Size}");
        }
    }
}
