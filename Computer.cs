using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Computer
    {
        public Display Display { get; set; }
        public Processor Processor { get; set; }
        public Winchester Winchester { get; set; }

        public Computer(Display display, Processor processor, Winchester winchester)
        {
            Display = display;
            Processor = processor;
            Winchester = winchester;
        }

        public virtual void Print()
        {
            Console.WriteLine("Ввывод информации о компьютере: ");
            Display.Print();
            Processor.Print();
            Winchester.Print();
        }
    }
}
