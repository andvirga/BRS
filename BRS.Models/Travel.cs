using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    /// <summary>
    /// Entity which represents an specific Travel to a destination
    /// </summary>
    public class Travel
    {
        public int Id { get; set; }

        [Required]
        public Destination Destination { get; set; }

        [Required]
        public List<Passenger> Passenger { get; set; }

        [Required]
        public Coordinator Coordinator { get; set; }

        [Required]
        public BusDriver BusDriver { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ReturnTime { get; set; }

    }
}
