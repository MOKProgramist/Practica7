// See https://aka.ms/new-console-template for more information
using Practica7;

Console.WriteLine("Начинаем создавать компьютер:");
// собираем компьютер
ComputingDevice computingDevice = new ComputingDevice(name: "Рабочая машинка", type: TypeDevice.PK, yearOfIssue: DateTime.Now);
computingDevice.Print();
