using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string Name {  get; set; }
        public string Location {  get; set; }
        public List<HotelRoom> RoomsList { get; set; }
        public List<HotelRoom> _availableRooms;
        
        public Hotel(string name, string location, List<HotelRoom> rooms)
        {
            Name = name;
            Location = location;
            RoomsList = rooms;
            _availableRooms = new List<HotelRoom>(rooms);
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {Name} - Available Rooms");
            foreach (HotelRoom room in _availableRooms)
            {
                Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.RoomStyle}, Price: {room.bookingPrice}");
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {Name} - Booked Rooms");
            foreach (var room in _availableRooms)
            {
                Console.WriteLine($"  Room {room.RoomNumber}, Style: {room.RoomStyle}, Price: {room.bookingPrice}");
            }
        }

        public Reservation BookRoom(Guest guest, HotelRoom room, DateTime startTime, DateTime endTime)
        {
            Reservation reservation = new Reservation(startTime, endTime, room);
            guest.ReservationsList.Add(reservation);
            return reservation;
        }
    }
}
