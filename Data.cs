using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Data
    {
        public Data()
        {
            Passenger passenger1 = new Passenger();
            passenger1.Email = "Mailens@mail.dk";
            passenger1.Name = "Pascal";
            passenger1.Description = "Meget dårlig mave!";
            passenger1.DoB = new DateTime(1933, 4, 21);
            passenger1.Gender = Person.GenderEnum.Other;
            
            PassengerList.Add(passenger1);

        }

        public List<Passenger> PassengerList = new List<Passenger>();
        public void ShowPassList()
        {
            foreach (Passenger p in PassengerList)
            {
                Console.WriteLine($"Name: {p.Name}    +Description: {p.Description}    +Age:{p.Age()}    +Email:{p.Email}   +Gender: {p.Gender}   ");
            }
        }
    }
}
