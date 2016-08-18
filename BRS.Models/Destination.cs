using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    /// <summary>
    /// Entity which represents a Travel Destination (E.G: Once, Flores, etc)
    /// </summary>
    public class Destination
    {
        public int DestinationId { get; set; }

        [Required]
        public string DestinationName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public ProvinceEnum Province { get; set; }

        [Required]
        public string Country { get; set; }

    }
}
