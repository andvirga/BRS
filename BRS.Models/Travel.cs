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
    /// Entity which represents an specific Travel to a destination
    /// </summary>
    public class Travel
    {
        public int TravelId { get; set; }

        [Required]
        public Destination Destination { get; set; }

        [Required]
        public List<Passenger> Passenger { get; set; }

        [Required, ForeignKey("CoordinatorId")]
        public Coordinator Coordinator { get; set; }

        public int CoordinatorId { get; set; }

        [Required, ForeignKey("BusDriverId")]
        public BusDriver BusDriver { get; set; }

        public int BusDriverId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ReturnTime { get; set; }
    }
}
