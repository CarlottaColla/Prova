using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClassi
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string Departement { get; set; }

        public void Stampa()
        {
            Console.WriteLine(FirstName + " " + LastName + " - " + Role + " " + Departement);
        }
    }
}
