using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Overloading_ConstructorChaining_Virtual
{
    class Person
    {
        // Fält att overrida
        protected string FirstName;
        protected string LastName;
        protected int Salary;
        protected string Status = "NULL";

        #region Constructor-Chaining med This (Overloading med andra ord)
        // Vi ska inte överanvända konstruktors utan vi använder de när vi redan så tidigt som möjligt vill instansiera våra fält ifall de är vitala för att det ska funka.
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName, string lastName, int salary) : this(firstName, lastName)
        {
            this.Salary = salary;
        }

        public Person(string firstName, string lastName, int salary, string status) : this(firstName, lastName, salary)
        {
            this.Status = status;
        }
        #endregion


        // Metod att overrida
        public virtual void PrintFullName()
        {
            Console.WriteLine("Namn: {0} {1}. Roll: Ej tillsatt.", FirstName, LastName);
            Console.ReadLine();
        }

    }
}
