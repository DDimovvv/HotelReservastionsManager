using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationsManager.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Room number")]
        public int RoomNumber { get; set; }
        [Range(2, 10)]
        [Required]
        public int Capacity { get; set; }
        public enum RoomTypes 
        {
            [Display(Name = "Two single beds")]
            Two_Single_Beds, 
            Apartment,
            [Display(Name = "Double bed")]
            Double_Bed, 
            Penthouse, 
            Maissonette 
        }
        [Display(Name = "Room type")]
        public RoomTypes RoomType { get; set; }
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
        [Required]
        [Display(Name = "Adult price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Adult price must be greater than 0")]
        public decimal AdultPrice { get; set; }
        [Required]
        [Display(Name = "Child price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Child price must be greater than 0")]
        public decimal ChildPrice { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
