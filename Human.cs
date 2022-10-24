using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        // отчество
        public string Patronymic { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Human(string lastName, string firstName, string patronymic, string address, DateOnly dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Address = address;
            DateOfBirth = DateOfBirth;
        }

        public string getFullName()
        {
            return LastName + FirstName + Patronymic;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Человек с ФИО {getFullName()}, адресом {Address} и датой рождения {DateOfBirth}")
        }
    }
}
