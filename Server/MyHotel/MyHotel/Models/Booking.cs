using System.ComponentModel.DataAnnotations.Schema;

namespace MyHotel.Models
{
    public enum Guests
    {
        One,
        Two,
        Three,
        Four
    }

    public enum NoRooms
    {
        One,
        Two,
        Three,
        Four
    }
    public class Booking
    {
        public int Id { get; set; }

        public ApplicationUser Customer { get; set; }
        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }

        public Room Rooms { get; set; }
        [ForeignKey(nameof(Rooms))]
        public int RoomId { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public Guests Guest { get; set; }
        public NoRooms  NoRoom { get; set; }
    }
}
