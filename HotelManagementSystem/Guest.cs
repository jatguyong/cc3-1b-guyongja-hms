using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Guest : User
    {
        public int totalNumberOfRooms;
        public List<Reservation> ReservationsList {  get; set; }

        public Guest(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
            ReservationsList = new List<Reservation>();
        }

        public void CreateReservation(Reservation reservation)
        {
            ReservationsList.Add(reservation);
        }

        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}:");
            foreach (Reservation reservation in ReservationsList)
            {
                Console.WriteLine($"  {reservation.reservationNum} Start Time: {reservation.startTime}, End Time: {reservation.endTime}, Duration: {reservation.duration}, Total: {reservation.total}");
            }
        }
    }
}
