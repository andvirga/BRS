using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    public abstract class Person
    {
        [Display(Name = "Nombre")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "D.N.I.")]
        [Required]
        public string DNI { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required]
        public DateTime DayOfBirth { get; set; }

        [Display(Name = "Direccion Principal")]
        [Required]
        public string PrimaryAddress { get; set; }

        [Display(Name = "Direccion Secundaria")]
        public string SecondaryAddress { get; set; }

        [Display(Name = "Telefono Principal")]
        [Required]
        public string PrimaryPhone { get; set; }

        [Display(Name = "Telefono Secundario")]
        public string SecondaryPhone { get; set; }

        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "Formato de E-Mail Invalido")]
        public string Email { get; set; }

        [Display(Name = "Ciudad")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Provincia")]
        [Required]
        public ProvinceEnum Province { get; set; }

        [Display(Name = "Pais")]
        [Required]
        public string Country { get; set; }
    }
}
