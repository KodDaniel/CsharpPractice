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
            var student = new Student("Daniel", "�hlin");
            var teacher = new Teacher( "Daniel", "�hlin");
            var person = new Person("Daniel", "�hlin");

            person.PrintFullName();
            student.PrintFullName();
            teacher.PrintFullName();
            
        }
    }
}
