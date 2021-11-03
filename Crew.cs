using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Crew : Person
    {
        public enum CrewRole { Captain, Pilote, Helmsman, Cook, Technician, Butler, Sailor, Ratcatcher}
        public DateTime WorkShift { get; set; } 
        //public bool OnDuty {get; set;} Man kunne her lave en "OnDuty -ifelse)
        public string IdCrew { get; set; }
        //    public enum PortsOfCall { Bangkok, HongKong, PortAuPrince, Esbjerg, Newcastle }
        //public PortsOfCall Gender { get; set; } = PortsOfCall.Bangkok;
    }
}
