using System;
using System.ComponentModel.DataAnnotations;

namespace Tonder.DTOs
{
    // DTOs are added so that we can use only the required field in a function
    public class RegisterDTO
    {
        [Required] public string UserName { get; set; }
        [Required] public string KnownAs { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Country { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }

    }
}
