using System;

namespace EsercizioClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person persona = new Person();
            //Console.WriteLine(persona.FirstName + " " + persona.LastName + " " + persona.Age);

            //persona.FirstName = "Matilde";
            //persona.LastName = "Pluto";
            //persona.Age = 30;

            //Console.WriteLine(persona.GetFullName());

            //Person[] persone = new Person[5];
            //Random age = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    persone[i] = new Person();
            //    persone[i].FirstName = "Nome" + (i + 1);
            //    persone[i].LastName = "Cognome" + (i + 1);
            //    persone[i].Age = age.Next(0, 100);
            //    Console.WriteLine(persone[i].GetFullName() + " " + persone[i].Age);
            //}

            //persona.Contacts = new Contacts
            //{
            //    PhoneNumber = 123,
            //    Email = "prova@gmail.com",
            //    Address = new Address
            //    {
            //        City = "Parma",
            //        State = "Italy",
            //        ZipCode = 43038
            //    }
            //};

            //Console.WriteLine(persona.GetFullName() + " " + persona.Contacts.Address.City);

            //Employee[] employees = EmployeeManagement.GetAllEmployees();
            //foreach (Employee employee in employees)
            //    employee.Stampa();

            //Console.WriteLine("Inserisci il nome da cercare: ");
            //string nome = Console.ReadLine();
            //Employee[] provaNome = EmployeeManagement.FilterFirstName(nome);
            //if (provaNome.Length == 0)
            //    Console.WriteLine("Nessun risultato");
            //else
            //    foreach (Employee employee in provaNome)
            //        employee.Stampa();

            //bool aggiunto = EmployeeManagement.AddEmployee();

            Employee employeeToRemove = new Employee
            {
                FirstName = "Alice",
                LastName = "Colella",
                Role = "Developer",
                Departement = "IT"
            };

            EmployeeManagement.RemoveEmployee(employeeToRemove);

        }

    }
}
