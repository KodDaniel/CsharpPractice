using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program

    {
        static void Main(string[] args)
        {
         
            GenericClass<decimal,char> obj = new GenericClass<decimal, char>(223233, 'A');

            obj.Print();
            Console.ReadLine();
        }
        public class GenericClass<T1,T2>
        {
            public T1 Date { get; set; }
            public T2 SecurityNumber { get; set; }

            public GenericClass(T1 date ,T2 securityNumber)
            {
                this.Date = date;
                this.SecurityNumber = securityNumber;
            }

            public void Print()
            {
                Console.WriteLine("Date är {0} och SecurityNumber är {1}.",Date,SecurityNumber);
            }

        }




    }








}








































//List<Player> genericList = new List<Player>();

//Populatelist(genericList);

//foreach (Player player in genericList)
//{
//Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, Lön= {3}", player.Id, player.Position, player.Name, player.Salary);
//}

//Console.ReadLine();
//}

//public static void Populatelist(List<Player> genericList)
//{
//// Skapar mina objekt
//Player player1 = new Player() { Id = 111132, Position = "Defense", Name = "Victor Hedman", Salary = 200000 };

//Player player2 = new Player() { Id = 22, Position = "Defense", Name = "Tobias Enström", Salary = 100000 };

//Player player3 = new Player() { Id = 212, Position = "Defense", Name = "Tom Hedberg", Salary = 13200000 };

//// Lägger in objekten i min lista
//genericList.Add(player1);
//genericList.Add(player2);
//genericList.Add(player3);
