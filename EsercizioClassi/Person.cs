using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClassi
{
    public class Person
    {
        //Campi
        //sono privati perchè non ci si può accedere
        //inizializzare un campo con valore di default
        //notazione camel
        private string firstName = "Pippo";
        private string lastName = "Sconosciuto";

        private int age; //usa il default di int

        //Proprietà
        //devono essere pubbliche perchè dobbiamo accederci
        //notazione pascal
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Address Address{ get; set;}

        public Contacts Contacts { get; set; }

    //Metodi
    public string GetFullName()
        {
            return firstName + " " + lastName;
        }

       

}
}
