using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class ComputingDevice
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateOnly YearOfIssue { get; set; }

        public ComputingDevice(string name, string type, DateOnly yearOfIssue)
        {
            Name = name;
            Type = type;
            YearOfIssue = yearOfIssue;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Вычислительное устройство с названием {Name} имеет тип {Type} и годом выпуска {YearOfIssue}");
        }
    }
}
