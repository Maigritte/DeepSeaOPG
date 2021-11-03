using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Person
    {
        public enum GenderEnum { Female, Male, Other }
        public GenderEnum Gender { get; set; } = GenderEnum.Other;
        public string Name { get; set; } 
        public string Email { get; set; }
        public string PhoneNo { get; set; }        
           public string Description { get; set; }
        public int Cabin { get; set; }
        public bool OnBoard { get; set; }   
        public DateTime DoB { get; set; } //metode, hvor man kan bede om alder, som returnerer alderen NU

        //Føds metode
        public int Age()
        {
            //TimeSpan t = DateTime.Now - DoB; //timespan: tid mellem to pubkter
            //DateTime dt = new DateTime(t.Ticks); //timespan udksrives i minutter, timer og sekunder, som bliver til DateTIme
            //int age = dt.Year;
            //return age; //til en TimeSpan

            DateTime checkDT = new DateTime(DateTime.Now.Year, DoB.Month, DoB.Day);
            int age = DateTime.Now.Year - DoB.Year -1;
            if (DateTime.Now > checkDT) age++;
            return age;

        }



    }
}
