using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sätter i konstruktorn endast det är allowed!
            var player = new Player("Peter Forsberg");
            
            // Sättet de värden jag KAN/ÄR TILLÅTEN att sätta härifrån
            player.Salary = 100;
            player.ContractTo = 2020;


        }
    }
}
