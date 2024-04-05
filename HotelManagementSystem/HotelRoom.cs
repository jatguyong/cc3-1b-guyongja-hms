using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{

    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public RoomStyle RoomStyle { get; set; }
        // public bool isRoomAvailable;
        public int bookingPrice;

        public HotelRoom(int roomNumber,  RoomStyle roomStyle, int bookingPrice)
        {
            RoomNumber = roomNumber;
            RoomStyle = roomStyle;
            this.bookingPrice = bookingPrice;
        }
    }
}
