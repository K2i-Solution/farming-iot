using System.ComponentModel.DataAnnotations;

namespace K2iSolution.AquaFarmingIoT.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
