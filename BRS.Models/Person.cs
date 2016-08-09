using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        public DateTime DayOfBirth { get; set; }

        [Required]
        public string PrimaryAddress { get; set; }

        public string SecondaryAddress { get; set; }

        [Required]
        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Email { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public ProvinceEnum Province { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
