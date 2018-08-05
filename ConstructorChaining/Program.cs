using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Daniel", "Åhlin");
            var teacher = new Teacher( "Daniel", "Åhlin");
            var person = new Person("Daniel", "Åhlin");

            person.PrintFullName();
            student.PrintFullName();
            teacher.PrintFullName();
            
        }
    }
}
