using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___aplikacja.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")] Low = 1,
        [Display(Name = "Normalny")] Normal = 2,
        [Display(Name = "Wysoki")] High = 3,
        [Display(Name = "Pilny")] Urgent = 4
    }
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wpisz adres email")]
        [EmailAddress(ErrorMessage = "Wpisano niepoprawny email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Wpisano niepoprawny nr telefonu")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime Birth { get; set; }

        [Display(Name = "Priorytet")]
        public string Priority { get; set; }
    }
}
