using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [ForeignKey("Room")]
        [Display(Name = "Room number")]
        public int RoomNumber { get; set; }
        public Room? Room { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User? User { get; set; }
        [Required]
        [Display(Name = "Check-in date")]
        public DateTime CheckInDate { get; set; }
        [Required]
        [Display(Name = "Check-out date")]
        public DateTime CheckOutDate { get; set; }
        [Display(Name = "Breakfast included")]
        public bool BreakfastIncluded { get; set; }
        [Display(Name = "All inclusive")]
        public bool AllInclusive { get; set; }
        [Required]
        [Display(Name = "Final Price")]
        public double FinalPrice { get; set; }
        public ICollection<ReservationClients>? ReservationClients { get; set; }
    }
}
