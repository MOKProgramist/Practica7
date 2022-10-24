using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Users: Human
    {
        public TypeUsers Type { get; set; }
        public Computer Computer { get; set; }
        
        public Users(string lastName, string firstName, string patronymic, string address, DateOnly dateOfBirth, TypeUsers typeUsers, Computer computer) : base(lastName, firstName, patronymic, address, dateOfBirth)
        {
            Type = typeUsers;
            Computer = computer;
        }

        public override void Print()
        {
            Console.WriteLine($"Пользователь с ФИО {getFullName()} с типом {Type}");
        }
    }

    public enum TypeUsers
    {
        Simple,
        Qualified,
        Specialist
    }
}
