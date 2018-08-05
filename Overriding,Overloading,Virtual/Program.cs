using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Overloading_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
          var person = new Person("Daniel","Åhlin");
          //var student = new Student();
          //var teacher = new Teacher();

            person.PrintFullName();
            //student.PrintFullName();           
            //teacher.PrintFullName();
        }  
    }
}
