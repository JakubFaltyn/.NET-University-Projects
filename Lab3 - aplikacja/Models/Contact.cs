using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3___aplikacja.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Wpisz imię")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długie imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wpisz adres email")]
        [EmailAddress(ErrorMessage = "Wpisano niepoprawny email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Wpisano niepoprawny nr telefonu")]
        public string Phone { get; set; }

        public DateTime Birth { get; set; }
    }
}
