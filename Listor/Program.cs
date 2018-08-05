using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar lista
            List<AdultTeam> modoFiveList = new List<AdultTeam>(4);

            // Skapar mina objekt
            AdultTeam player1 = new AdultTeam()
            {
                Id = 111132,
                Position = "Defense",
                Name = "Victor Hedman",
                Salary = 200000
            };

            AdultTeam player2 = new AdultTeam()
            {
                Id = 22,
                Position = "Defense",
                Name = "Tobias Enstr�m",
                Salary = 100000
            };
            AdultTeam player3 = new AdultTeam()
            {
                Id = 323,
                Position = "Left Wing",
                Name = "Markus N�slund",
                Salary = 80000000
            };
            AdultTeam player4 = new AdultTeam()
            {
                Id = 334,
                Position = "Center",
                Name = "Peter Forsberg",
                Salary = 90000000
            };
            AdultTeam player5 = new AdultTeam()
            {
                Id = 35,
                Position = "Right Wing",
                Name = "Niklas Sundstr�m",
                Salary = 7000000
            };

            // L�gger in objekten i min lista
            modoFiveList.Add(player1);
            modoFiveList.Add(player2);
            modoFiveList.Add(player3);
            modoFiveList.Add(player4);
            modoFiveList.Add(player5);

            // skapar ett JuniorObjekt
            JuniorTeam junior1 = new JuniorTeam()
            {
                Id = 12,
                Position = "Right Wing",
                Name = "Lukas Wernblom",
                Salary = 100,
                Parents = "Marie och Anders"

            };

            //// Testar att l�gga till det i listan
            ////modoFiveList.Add(junior1);

            //// L�gger in junioren l�ngst ned i listan med hj�lp av "Insert-Metoden". Till skillnad fr�n Add-metoden s� kan jag specifiera var jag vill l�gga in mitt objekt.
            //modoFiveList.Insert(5,junior1);

            //// Skapar for-each loop f�r utskrift
            //foreach (AdultTeam p in modoFiveList)
            //{
            //    Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}",p.Id,p.Position,p.Name,p.Salary);
            //}
            //Console.ReadLine();

            //// Unders�ker p� vilket index (position) i listan Peter Forsberg (player4) finns med hj�lp av metoden "IndexOf".
            //// Noter att IndefOf-metoden kan overloads med mer specifika argument som kan specificera var n�gonstans i listan s�kningen ska b�rja...
            ////.. samt hur m�nga element fr�n angivet startindex som ska g�s igenom.
            //Console.WriteLine("Peter Forsberg befinner sig p� position " + modoFiveList.IndexOf(player4));
            //Console.ReadLine();

            //// Kollar om Peter Forsberg (player4) finns i listan med hj�lp av Contains-metoden (som returnerar true eller false). 
            //if (modoFiveList.Contains(player4))
            //{
            //    Console.WriteLine("Peter Forsberg finns i listan");
            //}
            //else
            //{
            //    Console.WriteLine("Peter Forsberg finns INTE i listan");

            //}
            //Console.ReadLine();

            //  // Kollar om det finns spelare som tj�nar 7000000 i listan med hj�lp av Exist-metoden (som returnerar true eller false)
            //  if (modoFiveList.Exists(a => a.Name.StartsWith("Ni")))
            //  {
            //      Console.WriteLine("Det finns en person i listan vars namn b�rjar med str�ngen Ni");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Det finns INTE en person i listan vars namn b�rjar med str�ngen Ni");

            //  }
            //  Console.ReadLine();

            //// Notera att Exist-metoden bara returnerar en boleean, true eller false. Vi vill ha ett v�rde tillbaka, dvs det...
            // //...objekt som st�mmer �verens med v�rt villkor. F�r detta anv�nder vi Find-metoden!
            // // Notera att vi skapar ett objekt f�r att lagra v�rt resultat d� Find-metoden ju returnerar ett v�rde.
            // AdultTeam result =  modoFiveList.Find(a => a.Name.StartsWith("Ni"));

            //  Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", result.Id, result.Position, result.Name, result.Salary);
            //  Console.ReadLine();

            //Skapar en ny separat lista f�r att testa om jag kan sl� ihop dom.

            List<JuniorTeam> juniorList = new List<JuniorTeam>(3);

            // Skapar objekt
            JuniorTeam junior2 = new JuniorTeam()
            {
                Id = 13,
                Position = "Left Wing",
                Name = "Tim Walgren",
                Salary = 200,
                Parents = "Fredrik och Ulf"

            };

            JuniorTeam junior3 = new JuniorTeam()
            {
                Id = 14,
                Position = "Center",
                Name = "David Gunarsson",
                Salary = 50,
                Parents = "Ulrika och Niklas"

            };

            JuniorTeam junior4 = new JuniorTeam()
            {
                Id = 15,
                Position = "Left Wing",
                Name = "Emil Alba",
                Salary = 300,
                Parents = "Fiona och Kenneth"

            };

            // L�gger in de objekten i listan
            juniorList.Add(junior4);
            juniorList.Add(junior2);
            juniorList.Add(junior3);

            ////Dubbelkollar vad jag har i modo-FivelIST nu genom att skriva ut det.
            //Console.WriteLine("Listan INNAN ihopslagning:");
            //foreach (AdultTeam p in modoFiveList)
            //{
            //    Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}",p.Id, p.Position, p.Name, p.Salary);
            //}
            //Console.ReadLine();

            //Testar nu metoden Add-range. Jag g�r detta genom att sl� ihop listorna "juniorList" och "modoFiveList" till en och samma lista som jag kallar "mergedList".

            modoFiveList.AddRange(juniorList);

            Console.WriteLine("Listan 'modoFiveList' EFTER ihopslagning:");

            foreach (AdultTeam p in modoFiveList)
            {
                Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            }

            Console.ReadLine();

            // //  Vi vill nu ta bort alla som fr�n listan som har positionen center. Det borde inneb�ra att Peter Forsberg och David Gunarsson raderas fr�n listan.
            // modoFiveList.RemoveAll(a => a.Position == "Center");


            // Console.WriteLine("Listan EFTER ATT HA TAGIT BORT ALLA CENTRAR:");

            // foreach (AdultTeam p in modoFiveList)
            // {
            //     Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            // }
            // Console.ReadLine();

            // //Vi vill h�mta och skriva ut de TRE f�rsta spelarna fr�n listan "modoFiveList!
            //List<AdultTeam> threeFirstPlayerList = modoFiveList.GetRange(0, 3);

            // Console.WriteLine("De tre f�rsta spelarna i listan:");

            // foreach (AdultTeam p in threeFirstPlayerList)
            // {
            //     Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            // }
            // Console.ReadLine();

            // Listan sorterade efter namn

            //modoFiveList.Sort();
            //Console.WriteLine("Listan sorterade efter namn");

            //foreach (AdultTeam p in modoFiveList)
            //{
            //    Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            //}

            //Console.ReadLine();

            //// Sorterar i salary i reverse-ordning med hj�lp av classen "SortBySalary".

            //SortBySalary sortBySalary = new SortBySalary();
            //modoFiveList.Sort(sortBySalary);

            //Console.WriteLine("Listan efter l�n i stigande ordning");

            //foreach (AdultTeam p in modoFiveList)
            //{
            //    Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            //}
            //Console.ReadLine();

            //modoFiveList.Reverse();
            //Console.WriteLine("Listan efter l�n i sjunkande ordning");

            //foreach (AdultTeam p in modoFiveList)
            //{
            //    Console.WriteLine("Id = {0}, Position = {1}, Namn= {2}, L�n= {3}", p.Id, p.Position, p.Name, p.Salary);
            //}
            //Console.ReadLine();

            // Testar "TrueForAll-metoden" genom att testa om alla har en l�n �ver 300.

            //Console.WriteLine("Har alla medlemmar i listan en l�n �ver 300?. Svar: " + modoFiveList.TrueForAll(a => a.Salary > 300));
            //Console.ReadLine();

            //DICTIONARY

            // Vi instansierar v�rt Dictionary
            Dictionary<int, AdultTeam> adultTeamDictionary = new Dictionary<int, AdultTeam>();

            //Vi fyller v�rt Dictionary. L�gg m�rke till att vi anv�nder spelarnas ID som nycklar.
            adultTeamDictionary.Add(player1.Id, player1);
            adultTeamDictionary.Add(player2.Id, player2);
            adultTeamDictionary.Add(player3.Id, player3);

            // Vi loopar igenom v�rt Dictionary.
            foreach (KeyValuePair<int, AdultTeam> playerValuePair in adultTeamDictionary)
            {
                // skriver ut alla nycklar (ID:n)
                Console.WriteLine(playerValuePair.Key);
                Console.ReadLine();

                //Skriver ut alla v�rden. Notera att "value" �r lika med ett helt player-Objekt. D�rf�r v�ljer vi att skriva ut namnet f�r att det ska funka med Console.Writeline.
                Console.WriteLine(playerValuePair.Value.Name);
                Console.ReadLine();
            }

            //Vi g�r om listan "modoFiveList till ett dictionary
            // Notera att vi specificerar ID som nyckeln och playerobjekt som v�rden i v�rt nya Dictionary.
            Dictionary<int, AdultTeam> dictFromlist = modoFiveList.ToDictionary(a => a.Id, a => a);

            // Skriver ut nycklar och utvalda v�rden (Namn, position, l�n) fr�n v�rt nyskapade Dictionary.


            foreach (KeyValuePair<int, AdultTeam> a in dictFromlist)
            {

                Console.WriteLine("Nyckeln �r: "

                                  + a.Key);
                Console.ReadLine();

                Console.WriteLine("Position = {0}, Namn= {1}, L�n= {2}", a.Value.Name, a.Value.Position, a.Value.Salary);
                Console.ReadLine();
            }
        }

        public class SortBySalary : IComparer<AdultTeam>
        {
            public int Compare(AdultTeam x, AdultTeam y)
            {
                return x.Salary.CompareTo(y.Salary);
            }

        }

        // Skapar klassen ModoFIVE med relevanta egenskaper
        public class AdultTeam : IComparable<AdultTeam>
        {
            public int Id { get; set; }

            public string Position { get; set; }

            public string Name { get; set; }

            public int Salary { get; set; }

            public int CompareTo(AdultTeam other)
            {
                return Name.CompareTo(other.Name);
            }
        }

        // Skapar ytterligare en klass f�r att testa om jag kan l�gga in ett objekt av typen "JuniorTeam" i min lista som har typen "AdultTeam".
        public class JuniorTeam : AdultTeam
        {
            public string Parents { get; set; }
        }





















    }
}
