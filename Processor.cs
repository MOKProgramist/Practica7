using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Processor
    {

        public string Brand { get; set; }
        // мощность цп
        public string Power { get; set; }

        // наличие вентилятора
        public bool IsFan {get; set;}

        public Processor(string brand, string power, bool isFan) 
        {
           Brand = brand;
            Power = power;
            IsFan = isFan;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Процессор от бренда {Brand} с мощностью {Power} {(IsFan ? "не имеет вентилятор" : "с вентилятором")}");
        }
    }
}
