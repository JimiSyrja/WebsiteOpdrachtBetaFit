using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebsiteOdrachtBetaFit.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is a required field")]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Emailadress is required")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phonenummer is required")]
        [Phone(ErrorMessage = "Geen geldig telefoonnummer")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Adress not entered")]
/*        [Display(ErrorMessage = "Geen geldig ")]
*/        public string Adres { get; set; }
        [Required(ErrorMessage = "Message is necessary")]
        [Display(Name = "Message")]
        public string Description { get; set; }
        }
    }