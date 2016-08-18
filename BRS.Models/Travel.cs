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

        [ForeignKey("Destination")]
        public int DestinationId { get; set; }

        [Required]
        public virtual List<Passenger> Passengers { get; set; }

        [Required]
        public Coordinator Coordinator { get; set; }

        [ForeignKey("Coordinator")]
        public int CoordinatorId { get; set; }

        [Required]
        public BusDriver BusDriver { get; set; }

        [ForeignKey("BusDriver")]
        public int BusDriverId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ReturnTime { get; set; }

    }
}
