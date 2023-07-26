using System;

namespace Lobby
{
    class Guest
    {
        public bool RoomStatus;
        public string? Name; //No nullable
        public int NumGuests;
        public char CheckIn;
        public char CheckOut;

        public int NumGuest { get; internal set; }
    }
}