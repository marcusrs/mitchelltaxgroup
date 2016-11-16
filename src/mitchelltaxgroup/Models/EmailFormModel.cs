using System.ComponentModel.DataAnnotations;


namespace mitchelltaxgroup.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Your name")]
        [StringLength(30, MinimumLength =3, ErrorMessage ="Full Name characters must between 3 and 30")]
        public string FromName { get; set; }

        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        [MinLength(10, ErrorMessage ="Please leave a detail Message")]
        public string Message { get; set; }

    }
}

