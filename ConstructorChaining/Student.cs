using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Student : Person
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        // Overridar metod från superklass "Person"
        public override void PrintFullName()
        {
            Console.WriteLine("Namn: {0} {1}. Roll: Student.", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
