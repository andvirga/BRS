using BRS.Data.Interfaces;
using BRS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.Context
{
    /// <summary>
    /// Bus Reservation System DB Context (Main Class)
    /// </summary>
    public class BRSContext : DbContext, IBRSContext, IDbContext
    {
        #region Entity DbContexts

        /// <summary>
        /// Passenger DB Context
        /// </summary>
        public virtual IDbSet<Passenger> PassengerContext { get; set; }

        #endregion
    }
}
