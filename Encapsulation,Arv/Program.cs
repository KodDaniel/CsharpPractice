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
            // S�tter i konstruktorn endast det �r allowed!
            var player = new Player("Peter Forsberg");
            
            // S�ttet de v�rden jag KAN/�R TILL�TEN att s�tta h�rifr�n
            player.Salary = 100;
            player.ContractTo = 2020;


        }
    }
}
