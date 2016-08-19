using BRS.Models;
using System.Data.Entity;


namespace BRS.Data.Context
{
    /// <summary>
    /// Bus Reservation System DB Context (Main Class)
    /// </summary>
    public class BRSContext : DbContext
    { 
        #region Entity DbContexts

        /// <summary>
        /// Passenger DB Context
        /// </summary>
        public IDbSet<BusDriver> BusDriverContext { get; set; }

        public IDbSet<Coordinator> CoordinatorContext { get; set; }

        public IDbSet<Destination> DestinationContext { get; set; }

        public IDbSet<Passenger> PassengerContext { get; set; }

        public IDbSet<Travel> TravelContext { get; set; }

        #endregion

        public System.Data.Entity.DbSet<BRS.Models.Passenger> Passengers { get; set; }
    }
}
