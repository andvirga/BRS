using BRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.Repository
{
    public class PassengerRepository : BaseRepository<Passenger>
    {
        #region Custom Methods

        public Passenger GetPassengerByDNI(string DNI)
        {
            var passengerList = this.GetAll();

            var passenger = passengerList.Where(p => p.DNI == DNI).FirstOrDefault();

            return passenger;
        }

        #endregion
    }
}
