using System.Collections.Generic;

namespace authForm.Models
{
    public static class RoomRepository
    {
        public static List<Room> GetRooms()
        {
            return new List<Room>
            {
                new Room {Name = "Номер с видом на океан"},
                new Room {Name = "Одиночный номер"},
                new Room {Name = "номер с бассейном и кинотеатром"}
            };
        }
    }
}