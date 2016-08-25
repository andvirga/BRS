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
        public DbSet<BusDriver> BusDriverContext { get; set; }

        public DbSet<Coordinator> CoordinatorContext { get; set; }

        public DbSet<Destination> DestinationContext { get; set; }

        public DbSet<Passenger> PassengerContext { get; set; }

        public DbSet<Travel> TravelContext { get; set; }

        #endregion

    }
}
