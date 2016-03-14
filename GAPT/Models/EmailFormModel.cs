using System.ComponentModel.DataAnnotations;

namespace MVCEmail.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "ToursMaltin")]
        public string FromName { get; set; }
        [Required, Display(Name = "toursmaltin@gmail.com"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }
    }
}