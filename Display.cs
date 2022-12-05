
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Display
    {
        public string Brand { get; set; }
        public string ScreenSize { get; set; }
        public DateOnly YearOfIssue { get; set; }

        public Display(string brand, string screenSize, DateOnly yearOfIssue)
        {
            Brand = brand;
            ScreenSize = screenSize;
            YearOfIssue = yearOfIssue;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Дисплей от бренда {Brand} имеет размер экрана {ScreenSize} и годом выпуска {YearOfIssue}");
        }
    }
}
