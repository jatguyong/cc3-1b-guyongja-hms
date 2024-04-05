using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Reservation
    {
        public int reservationNum;
        public DateTime startTime;
        public DateTime endTime;
        public int duration;
        public HotelRoom room;

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.room = room;

            TimeSpan timeDifference = endTime - startTime;
            this.duration = timeDifference.Hours;
        }

        public void GetDetails()
        {
            // {Make} {Model} ({Year}) - Registration: {RegistrationNumber}, Rent Price: {RentalPricePerDay} per day"
        }
    }
}
