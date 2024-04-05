﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotelList = new List<Hotel>();

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
            Console.WriteLine($"User {user.Name} registered successfully.");
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            if (!hotelList.Contains(hotel))
            {
                Console.WriteLine("Error: Hotel not found.");
                return;
            }

            Reservation reservation = hotel.BookRoom(guest, room, startTime, endTime);
            if (reservation != null)
            {
                guest.CreateReservation(reservation);
            }
        }

        public void DisplayReservationDetails(int v)
        {

        }

    }
}
