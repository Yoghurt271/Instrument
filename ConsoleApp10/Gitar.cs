using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Gitar : Instrument
    {
        int strings;
        public Gitar(int strings)
        {
            this.strings = strings;
        }

        public void play()
        {
            Console.WriteLine($"Играет гитара, количество струн {strings} ");
        }
    }
}
