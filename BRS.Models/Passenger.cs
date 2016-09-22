using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    /// <summary>
    /// Passenger EF Model
    /// </summary>
    public class Passenger
    {
        public Person Person { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public int PassengerId { get; set; }

        [Display(Name = "Historial de Viajes")]
        public string TravelHistory { get; set; }
    }
}
