using System.ComponentModel.DataAnnotations;

namespace K2iSolution.AquaFarmingIoT.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}