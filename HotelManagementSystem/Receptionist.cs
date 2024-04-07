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
            guest.ReservationsList.Add(reservation);
        }
    }
}
