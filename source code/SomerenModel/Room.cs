namespace SomerenModel
{
    public class Room
    {
        public string kamernummer { get; init; }
        public RoomType roomType { get; init; }

        public Room(string kamernummer, RoomType roomType) {
            this.kamernummer = kamernummer;
            this.roomType = roomType;
        }
    }
}