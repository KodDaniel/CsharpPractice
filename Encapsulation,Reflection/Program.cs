using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Type T = typeof(Player);

            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo c in constructors)
            {
                Console.WriteLine(c.ToString());
            }

            Console.ReadLine();
            


            // S�tter i konstruktorn d� ENDAST det �r allowed!
            var player = new Player("Peter Forsberg");



            // S�ttet de v�rden jag KAN/�R TILL�TEN att s�tta h�rifr�n.
            var salary = player.Salary = 120;
           var contract = player.ContractTo = 2020;

            Console.WriteLine("{0} spelar i {1}, har kontrakt till {2} och tj�nar {3} kronor per sekund.",player.Name,player.Team,contract,salary);
            Console.ReadLine();

        }

    }

}
