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

        public void CreateBooking()
        {

        }

        public void BookReservation(Guest guest, Reservation reservation)
        {
            if (hotel == null)
            {
                Console.WriteLine("Error: Hotel not found.");
                return;
            }

            if (!hotel.IsRoomAvailable(room.RoomNumber, startTime, endTime))
            {
                Console.WriteLine($"Room {room.RoomNumber} is not available for the specified duration.");
                return;
            }

            Reservation reservation = hotel.BookRoom(room, startTime, endTime);
            if (reservation != null)
            {
                guest.AddReservation(reservation);
                Console.WriteLine($"Reservation booked for {guest.Name} by {Name}.");
            }
        }
    }
}
