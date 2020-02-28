using System.ComponentModel.DataAnnotations;

namespace DisasterRecoveryAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 20 characters long.")]
        public string Password {get; set;}
    }
}