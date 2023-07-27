using System;

namespace Lobby
{
    public class Guest
    {
        public bool RoomStatus;
        public string? Name; //No nullable
        public int NumGuests;
        public string CheckIn;
        public string CheckOut;

        public int NumGuest { get; internal set; }
    }

    public static class HotelFeatures
    {
        public const int Floors = 3;
        public const int RoomPerFloor = 5;
        public static Guest[,] HotelRooms = new Guest[Floors, RoomPerFloor];

        /*This method initializes the HotelRooms array 
        with all rooms with status false*/
        static HotelFeatures()
        {
            for (int i = 0; i < Floors; i++)
            {
                for (int j = 0; j < RoomPerFloor; j++)
                {
                    HotelRooms[i, j] = new Guest();
                    HotelRooms[i, j].RoomStatus = false;
                }
            }
        }
    }
}