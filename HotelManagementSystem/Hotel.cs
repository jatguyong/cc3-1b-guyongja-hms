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
        public List<HotelRoom> Rooms { get; set; }
        public List<HotelRoom> _availableRooms;

        public Hotel(string name, string location, List<HotelRoom> rooms)
        {
            Name = name;
            Location = location;
            Rooms = rooms;
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
        }

        public Reservation BookRoom(Guest guest, HotelRoom room, DateTime startTime, DateTime endTime)
        {
            if (!IsRoomAvailable(room, startTime, endTime))
            {
                Console.WriteLine($"Room {room.RoomNumber} is not available for the specified duration.");
                return null;
            }

            Reservation reservation = new Reservation(startTime, endTime, room);
            guest.CreateReservation(reservation);
            return reservation;
        }

        private bool IsRoomAvailable(HotelRoom room, DateTime startTime, DateTime endTime)
        {
            return true;
        }
    }
}
