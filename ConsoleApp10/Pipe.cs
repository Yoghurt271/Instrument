using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Pipe : Instrument
    {
        int Diameter;
        public Pipe(int Diameter)
        {
            this.Diameter = Diameter;
        }

        public void play()
        {
            Console.WriteLine($"Играет труба, диаметр {Diameter} ");
        }
    }
}
