using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Reservation
    {
        public static int reservationCount = 1234567890;
        public int ReservationNum {  get; }
        public DateTime StartTime {  get; }
        public DateTime EndTime {  get; }
        public int Duration {  get; }
        public HotelRoom Room {  get; }

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            ReservationNum = reservationCount++;
            StartTime = startTime;
            EndTime = endTime;
            Room = room;

            Duration = (endTime - startTime).Days;
        }

        public int TotalPrice()
        {
            return Duration * Room.bookingPrice;
        }
    }
}
