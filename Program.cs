// See https://aka.ms/new-console-template for more information
using Practica7;

Console.WriteLine("Начинаем создавать компьютер:");
Display display = new Display(brand: "ЛОС", screenSize: "27", yearOfIssue: DateTime.Now);
Processor processor = new Processor(brand: "AMD", power: "4.2гц");
Winchester winchester = new Winchester(size: "1 террабайт", type: "3.5");
// присоединеения комплектующих 
Computer computer = new Computer(display, processor, winchester);
// информвация о компьютере
computer.Print();
