using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EsercizioClassi
{
    public class EmployeeManagement
    {
        public static string path { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Employees.csv");
        //lettura di tutti gli employees

        public static Employee[] GetAllEmployees()
        {
            int totLines = File.ReadLines(path).Count();
            Employee[] employees = new Employee[totLines - 1];
            string line;

            using(StreamReader reader = File.OpenText(path))
            {
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    for(int i = 0; i < totLines -1; i++)
                    {
                        line = reader.ReadLine();
                        string[] employeeData = line.Split(",");
                        Employee employee = new Employee
                        {
                            FirstName = employeeData[0],
                            LastName = employeeData[1],
                            Role = employeeData[2],
                            Departement = employeeData[3]
                        };
                        employees[i] = employee;

                    }
                }
            }
            return employees;
        }

        public static Employee[] FilterFirstName(string name)
        {
            //con questo metodo rileggo i dati del file, questa applicazione può aver modificato i dati
            //e non averli scritti sul file, quali sono attendibili?
            //si può rifare questa funzione prendendo l'array in input
            Employee[] employees = GetAllEmployees();
            ArrayList employeeName = new ArrayList();

            for(int i = 0; i <employees.Length; i++)
            {
                if(employees[i].FirstName == name)
                {
                    employeeName.Add(employees[i]);
                }
            }

            //Employee[] employeesRis = new Employee[employeeName.Count];
            //int index = 0;
            //foreach(Employee employee in employeeName)
            //{
            //    employeesRis[index] = employee;
            //    index++;
            //}
            //return employeesRis;

            return (Employee[])employeeName.ToArray(typeof(Employee));
        }

        //Aggiungere un employee su file
        public static bool AddEmployee()
        {
            Employee employeeToAdd = new Employee();
            Console.WriteLine("Inserisci il nome dell'impiegato da aggiungere: ");
            employeeToAdd.FirstName = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome dell'impiegato da aggiungere: ");
            employeeToAdd.LastName = Console.ReadLine();
            Console.WriteLine("Inserisci il ruolo dell'impiegato da aggiungere: ");
            employeeToAdd.Role = Console.ReadLine();
            Console.WriteLine("Inserisci il dipartimento dell'impiegato da aggiungere: ");
            employeeToAdd.Departement = Console.ReadLine();

            try
            {
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(employeeToAdd.FirstName + "," + employeeToAdd.LastName + "," + employeeToAdd.Role + "," + employeeToAdd.Departement);
                }
                Console.WriteLine("Impiegto aggiunto con successo!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
                throw;
            }
            return false;

        }

        public static bool RemoveEmployee (Employee employeeToRemove)
        {
            Employee[] allEmployees = GetAllEmployees();
            ArrayList employeesToNotRemoveList = new ArrayList();
            for (int i = 0; i < allEmployees.Length; i++)
            {
                if (!(allEmployees[i].FirstName == employeeToRemove.FirstName &&
                    allEmployees[i].LastName == employeeToRemove.LastName &&
                    allEmployees[i].Role == employeeToRemove.Role &&
                    allEmployees[i].Departement == employeeToRemove.Departement))
                {
                    employeesToNotRemoveList.Add(allEmployees[i]);
                }
            }
            Employee[] employeesToWrite = (Employee[])employeesToNotRemoveList.ToArray(typeof(Employee));
            try
            {
                using(StreamWriter file = File.CreateText(path))
                {
                    file.WriteLine("firstName,lastName,role,departement");
                    for(int i = 0; i < employeesToNotRemoveList.Count -1; i++)
                    {
                        file.WriteLine(employeesToWrite[i].FirstName + "," + employeesToWrite[i].LastName + "," + employeesToWrite[i].Role + "," + employeesToWrite[i].Departement);
                    }
                }
                Console.WriteLine("Cancellato con successo!");
                return true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
                throw;
            }
            return false;
        }

    }
}
