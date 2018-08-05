using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Arv
{
    class Player
    {
      
        // Read-Only. Eftersom jag utelämnar "set" helt så kan jag bara sätta namnet i klassens konstruktor. Jag kan inte ens anropa det i andra metoder i denna klass.
        // För skillnad: Se propertien Team som begränsas till den här klassen, men utan att vara onåbara för andra metoder än konstruktorn i denna klass.
        public string Name { get; }
        public string Team { get; private set; }
        public int ContractTo { get; set; }
        public int Salary { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
       
        // Funkar då jag förvisso begränsar med set, men "bara" begränsar så att endast den här klassen når den.       
        public void SetTeam(string team)
        {
            this.Team = team;
        }



        //// Funkar ej då jag bara har "get;" vilket begränsar till enbart konstruktorn.
        //public void setName(string name)
        //{
        //    this.Name = name;
        //}


    }
   
}


