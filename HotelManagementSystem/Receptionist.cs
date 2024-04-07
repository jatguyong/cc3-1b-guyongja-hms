using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Receptionist : User
    {
        public Receptionist(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
        }

        public void BookReservation(Guest guest, Reservation reservation)
        {
            // Here you can implement the logic for booking a reservation by a receptionist.
            guest.CreateReservation(reservation);
            Console.WriteLine($"Reservation booked for {guest.Name} by {Name}.");
        }
    }
}
