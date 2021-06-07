using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimothyHsu_PartyMVC.Models
{
    public class Visitor
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Please enter your surname")]
        public string SecondName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Please enter your age")]
        [Range(18,60,ErrorMessage = "Please enter a value between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your postal code")]
        [Range(1000, 1500, ErrorMessage = "Please enter a value between 1000 and 1500")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select an option")]
        public bool IsFamily { get; set; }

    }
}
