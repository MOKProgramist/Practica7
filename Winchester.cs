using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Winchester
    {
        public string Size { get; set; }
        public string Type { get; set; }

        public Winchester(string size, string type)
        {
            Size = size;
            Type = type;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Винчестер имеет размер {Size} и тип {Type}");
        }
    }
}
