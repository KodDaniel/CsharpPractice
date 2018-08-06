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
            


            // Sätter i konstruktorn då ENDAST det är allowed!
            var player = new Player("Peter Forsberg");



            // Sättet de värden jag KAN/ÄR TILLÅTEN att sätta härifrån.
            var salary = player.Salary = 120;
           var contract = player.ContractTo = 2020;

            Console.WriteLine("{0} spelar i {1}, har kontrakt till {2} och tjänar {3} kronor per sekund.",player.Name,player.Team,contract,salary);
            Console.ReadLine();

        }

    }

}
