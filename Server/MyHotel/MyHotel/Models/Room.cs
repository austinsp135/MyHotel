namespace MyHotel.Models
{
    public enum Type
    {
        Presidetial_Suite,
        Superior_Room,
        Premier_Room,
        Delux_Suite
        
    }
    public enum Btype
    {
        Single,
        Duoble,
        King_Size,
        Queen_Size
    }
    public class Room
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string FloorNo { get; set; }
        public Type RoomType { get; set; }
        public Btype BedType { get; set; }

        public int RoomCount { get; set; } 
        public string RoomRate { get; set;}
    }
}
