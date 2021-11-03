using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Ticket
    {
        public enum PortsOfCallEnum { Bangkok, HongKong, PortAuPrince, Esbjerg, Newcastle, Mandalay }
        public PortsOfCallEnum Origin { get; set; } = PortsOfCallEnum.Bangkok;
        public PortsOfCallEnum Destination { get; set; } = PortsOfCallEnum.Bangkok;
        public DateTime DepartureDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TicketId { get; set; }
        public int CabinNo { get; set; }
        public bool ScheduledOnBoard { get; set; } //Til senere. If else, om de har behov for at check om de er ombord
    }
}
