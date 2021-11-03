using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaOPG
{
    internal class Menu
    {
        Data dataBase = new Data();

        public Menu() //constructor (metode uden returtype)
        {
            //Her startes menustystem
            
            MenuSwitch(); //Her kaldes metoden.
           
        }

        private void MenuSwitch()
        {
            


            while (true) //Kør menu i ring
            {
                //Forside
                Console.WriteLine("Maritime Administrative System\n \n");
                Console.WriteLine("1: Create Passenger \n2: Create Crew \n 4: Show All Passengers ");
                //string choice = Console.ReadLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("1 Create passenger");
                        //Lave ny Passager, som gemmes
                        Passenger p = CreatePassenger();
                        dataBase.PassengerList.Add(p);
                        //Vend tilbage til hoved menu

                        break;
                    case "2":
                        Console.WriteLine("2 Create crew member");
                        //Lave ny crew, som gemmes
                        CreateCrew();
                        //Vend tilbage til hoved menu
                        break;

                    case "3":
                        Console.WriteLine("3 Buy Ticket");
                        //Vend tilbage til hoved menu
                        break;

                    case "4":
                        Console.WriteLine("4 Show all Passengers");
                        dataBase.ShowPassList();
                        break;

                    case "10":
                        Console.WriteLine("X Return to menu");
                        break;
                                         
                    default:
                        break;
                }
                //Oprette passager
                //Oprette billet 
            }
        
        }

        //Inputmetoder 
        private Passenger CreatePassenger() //metoden, som skal oprette en person
        {
            Passenger passenger = new Passenger();
            Console.Write("Name of Passenger: ");
            passenger.Name = Console.ReadLine();

            Console.Write("Allergies, dietary needs, etc.: ");
            passenger.Description = Console.ReadLine();

            ////xx metode skal genereres
            //passenger.IdPassenger = Console.ReadLine(); //metode som skal have et fortløbende nummer

            foreach (var g in Enum.GetValues(typeof(Person.GenderEnum)))
            {
                Console.WriteLine((int)g + g.ToString());
            }
            Console.Write("Gender: ");
            passenger.Gender = (Person.GenderEnum)int.Parse(Console.ReadLine());
            
            //autogenerate cabin --> relate to ticket type
            //passenger.Cabin = int.Parse(Console.ReadLine());

            //yyyy-mm-dd
            Console.Write("Please write the date of birth (yyyy-mm-dd): ");
            passenger.DoB = DateTime.Parse(Console.ReadLine());
            return passenger;

        }

        private Crew CreateCrew()
        { 
            Crew crew = new Crew();

            Console.Write("Name of crew member: ");
            crew.Name = Console.ReadLine();
             
            return crew;
        }
    }
}
