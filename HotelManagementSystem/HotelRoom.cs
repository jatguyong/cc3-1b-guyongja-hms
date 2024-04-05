using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    enum RoomStyle
    {
        TwinRoom,
        QueenRoom,
        KingRoom
    }

    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public string RoomStyle { get; set; }
        public bool isRoomAvailable;
        public int bookingPrice;

        public HotelRoom(int roomNumber, string roomStyle, bool isRoomAvailable, int bookingPrice)
        {
            RoomNumber = roomNumber;
            RoomStyle = roomStyle;
            this.isRoomAvailable = isRoomAvailable;
            this.bookingPrice = bookingPrice;
        }
    }
}
