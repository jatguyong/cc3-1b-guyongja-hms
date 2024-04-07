using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotelList;
        private List<User> userList;

        public HotelManagementSystem()
        {
            hotelList = new List<Hotel>();
            userList = new List<User>();
        }


        public void AddHotel(Hotel hotel)
        {
            hotelList.Add(hotel);
        }


        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (Hotel hotel in hotelList)
            {
                Console.WriteLine($"  {hotel.Name}, {hotel.Location}");
            }
        }

        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            if (!hotelList.Contains(hotel))
            {
                Console.WriteLine("Error: Hotel not found.");
                return;
            }   

            Reservation reservation = hotel.BookRoom(guest, room, startTime, endTime);
        }

        public void DisplayReservationDetails(int reservationNum)
        {
            foreach (var user in userList)
            {
                if (user is Guest guest)
                {
                    foreach (var reservation in guest.ReservationsList)
                    {
                        if (reservation.ReservationNum == reservationNum)
                        {
                            Console.WriteLine($"{reservation.ReservationNum} Start Time: {reservation.StartTime}, End Time {reservation.EndTime}, Duration: {reservation.Duration}, Total: {reservation.Room.bookingPrice}");
                            return;
                        }
                    }
                }

            }
        }
    }
}
