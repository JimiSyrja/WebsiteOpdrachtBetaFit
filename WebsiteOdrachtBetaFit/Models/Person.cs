using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebsiteOdrachtBetaFit.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Achternaam is een verplicht veld")]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Emailadres is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefoonnummerr is verplicht")]
        [Phone(ErrorMessage = "Geen geldig telefoonnummer")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Adres is verplicht")]
/*        [Display(ErrorMessage = "Geen geldig ")]
*/        public string Adres { get; set; }
        [Required(ErrorMessage = "Bericht is verplicht")]
        [Display(Name = "Bericht")]
        public string Description { get; set; }
        }
    }