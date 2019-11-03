using System;
using System.Collections.Generic;
using System.Text;

namespace hotel_management
{
    enum RoomType
    {
        SINGLE,
        DOUBLE,
        TRIPLE,
    }
    enum RoomStatus
    {
        EMPTY,
        OCCUPIED,
    }
    class Room
    {
        private Guid roomID;
        private Guid hotelID;
        private RoomType roomType;
        private RoomStatus roomStatus;

        public Room(Hotel hotel, RoomType roomType )
        {
            this.roomID = Guid.NewGuid();
            this.hotelID = hotel.HotelID;
            this.roomStatus = RoomStatus.EMPTY;
            this.roomType = roomType;

        }
        public Boolean IsRoomEmpty(Room room)
        {
            return room.roomStatus == RoomStatus.EMPTY ? true : false;
        }
        public void CheckIn(Room room)
        {
            room.roomStatus = RoomStatus.OCCUPIED;
        }
        public void CheckOut(Room room)
        {
            room.roomStatus = RoomStatus.EMPTY;
        }
        

    }
}