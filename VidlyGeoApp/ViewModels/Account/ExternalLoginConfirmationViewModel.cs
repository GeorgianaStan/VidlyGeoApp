using System.ComponentModel.DataAnnotations;

namespace VidlyGeoApp.ViewModels.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }
    }
}