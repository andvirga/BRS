using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    /// <summary>
    /// Passenger EF Model
    /// </summary>
    public class Passenger : Person
    {
        public int PassengerId { get; set; }

        [Display(Name = "Historial de Viajes")]
        public string TravelHistory { get; set; }
    }
}
