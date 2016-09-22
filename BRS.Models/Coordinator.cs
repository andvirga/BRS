using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Models
{
    public class Coordinator
    {
        public Person Person { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public int CoordinatorId { get; set; }
    }
}
