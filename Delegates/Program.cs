using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vi vill implementera kod som gör det möjligt att sortera spelare baserade på OLIKA krieter för att bedöma om vilja signa.
            // Kriterier: Salary, LeftContract, Age, Points.
            List<NHLPlayer> players = new List<NHLPlayer>();
            
            var player1 = new NHLPlayer(){Name = "Nicklas Bäckström",Salary = 300,LeftOnContract = 3,Age= 31,Points=93};
            var player2 = new NHLPlayer() { Name= "Sidney Crosby",Salary = 1300, LeftOnContract = 1, Age = 21, Points = 53 };
            var player3 = new NHLPlayer() { Name= "Peter Forsberg",Salary = 2300, LeftOnContract = 2, Age = 24, Points = 73 };
            var player4 = new NHLPlayer() { Name="Markus Näslund",Salary = 3200, LeftOnContract = 7, Age = 31, Points = 87 };
            var player5 = new NHLPlayer() { Name = "Mats Sundin",Salary = 200, LeftOnContract = 4, Age = 33, Points = 24 };

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            NHLPlayer.ResignPlayer(players,isResignible);
               
        }

        // Skapar delegate
        public delegate bool IsResignible(NHLPlayer player);
        
        //Skapar instans av Delegate
        // Skickar in metoden "Resign" (se nedan)
        static IsResignible isResignible = new IsResignible(Resign);
        
        // Resign-funktionen nedanb lir logiken.
        // Denna exempelfunktion skvallrar om att den aktuella klubben vill kolla på ålder, inte på kontraktslängd.
        public static  bool Resign(NHLPlayer player)
        {
            if (player.Age < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public class NHLPlayer
        {
            public int Salary{ get; set; }
            public int LeftOnContract { get; set; }
            public int Age { get; set; }
            public int Points{ get; set; }
            public string Name { get; set; }

            public static void ResignPlayer(List<NHLPlayer> listOfPlayers,IsResignible resignDelegate)
            {
                foreach (NHLPlayer player in listOfPlayers)
                {
                    // Nu finns igen logik här - den bestäms av användarna. Flexibelt!
                    if (resignDelegate(player))
                    {
                        Console.WriteLine(player.Name + " bör resignas.");

                    }
                }
                Console.ReadLine();

            }

        }

    }
}
