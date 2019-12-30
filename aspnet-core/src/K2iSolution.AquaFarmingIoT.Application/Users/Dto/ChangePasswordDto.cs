using System.ComponentModel.DataAnnotations;

namespace K2iSolution.AquaFarmingIoT.Users.Dto
{
    public class ChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
