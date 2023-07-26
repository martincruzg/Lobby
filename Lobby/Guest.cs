using System;

namespace Lobby
{
    class Guest
    {
        public bool RoomStatus;
        public string? Name; //No nullable
        public int NumGuests;
        public string? CheckIn;
        public string? CheckOut;

        public int NumGuest { get; internal set; }
    }
}