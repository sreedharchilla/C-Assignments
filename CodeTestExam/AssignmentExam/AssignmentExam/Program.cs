using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExam
{
    class Passenger
    {
        string name;
        string DateofTravel;
        int Age;
        Passenger(string name, string DateofTravel, int Age)
        {
            this.name = name;
            this.DateofTravel = DateofTravel;
            this.Age = Age;
        }



        public void TicketBooking(int no_of_tickets)
        {
            Console.WriteLine($"The passenger details is Age {Age}, Name is {name}, Date of travel is { DateOfTravel}, no.of tickets is {no_of_Tickets}");
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("No more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets successfully: {0}", no_of_tickets);



            }
        }



        public class TicketsException : Exception
        {
            public TicketsException(string message) : base(message)
            {
            }
        }



        public static void Main()
        {
            int no_tickets;
            no_tickets = Convert.ToInt32(Console.Read());
            Console.WriteLine(no_tickets);
            Passenger pass = new Passenger("Sreedhar", "24-04-2022", 21);
            pass.TicketBooking(no_tickets);
        }
    }
}
