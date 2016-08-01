using System;
using System.Collections.Generic;
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
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DNI { get; set; }

        public string PrimaryAddress { get; set; }

        public string SecondaryAddress { get; set; }

        public string Telephone { get; set; }

        public string Cellphone { get; set; }

        public string Email { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string City { get; set; }

        public ProvinceEnum Province { get; set; }

        public string Country { get; set; }
    }
}
