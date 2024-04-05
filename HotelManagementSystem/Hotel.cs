using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Hotel
    {
        public string name;
        public string location;
        public List<HotelRoom> _availableRooms;

        public Hotel()
        {
            _availableRooms = new List<HotelRoom>();
        }

        public void DisplayAvailableHotelRooms()
        {
            Console.WriteLine("Available Rooms:");
            foreach (HotelRoom room in _availableRooms)
            {
                Console.WriteLine("\t" + room.GetDetails());
            }
        }
    }
}
