using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    enum TypeDevice
    {
        PHONE, PAD, PK
    }
    internal class ComputingDevice
    {
 
        public string Name { get; set; }
        public TypeDevice Type { get; set; }
        public DateTime YearOfIssue { get; set; }

        private Computer Computer { get; set; }
        public ComputingDevice(string name, TypeDevice type, DateTime yearOfIssue)
        {
            Name = name;
            Type = type;
            YearOfIssue = yearOfIssue;

            if (type == TypeDevice.PK)
            {
                // Создаем компьютер
                Display display = new Display(brand: "ЛОС", screenSize: "27", yearOfIssue: DateTime.Now);
                Processor processor = new Processor(brand: "AMD", power: "4.2гц");
                Winchester winchester = new Winchester(size: "1 террабайт", type: "3.5");

                Computer computer = new Computer(display, processor, winchester);

                Computer = computer;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Вычислительное устройство с названием {Name} имеет тип {Type} и годом выпуска {YearOfIssue}");
            Computer.Print();
        }

    }
}
