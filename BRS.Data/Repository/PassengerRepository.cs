using BRS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.Repository
{
    public class PassengerRepository : BaseRepository<Passenger>
    {
        public override List<Passenger> GetAll()
        {
            return base.Context.Set<Passenger>().Include("Person").ToList();
        }

        public override Task<List<Passenger>> GetAllAsync()
        {
            return base.Context.Set<Passenger>().Include("Person").ToListAsync();
        }

        public override Task<Passenger> FindByIdAsync(int id)
        {
            return base.Context.Set<Passenger>().Include("Person").Where(p => p.PersonId == id).SingleOrDefaultAsync();
        }
    }
}
