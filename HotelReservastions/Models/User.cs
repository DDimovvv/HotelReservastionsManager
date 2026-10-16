using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationsManager.Models
{
    public class User:IdentityUser
    {
        [Required]
        [StringLength(10), MinLength(10)]
        public string EGN { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Phone number")]
        public override string? PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }
        [Required]
        [Display(Name = "Hire date")]
        public DateOnly HireDate { get; set; }
        public bool Active { get; set; }

        [Display(Name = "Release date")]
        public DateOnly? ReleaseDate { get; set; } = null;
    }
}
