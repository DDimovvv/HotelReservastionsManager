using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Adult { get; set; }
        public ICollection<ReservationClients>? ReservationClients { get; set; }
    }
}
