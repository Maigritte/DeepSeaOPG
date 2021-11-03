using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Passenger : Person

    //Udkommenterede skal migreres til Ticket cs
    {
       
        public bool PetCheck { get; set; }
        public bool TicketCheck { get; set; }
        public string IdPassenger { get; set; }
    }

    internal class Pet
    {
        public string PetName { get; set; }
        public string PetType { get; set; }
    }
}
