using BRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.Data.Repository
{
    public class PersonRepository : BaseRepository<Person>
    {
        #region Custom Methods

        public virtual Person GetPersonByDNI(string DNI)
        {
            var persons = this.GetAll();

            var person = persons.Where(p => p.DNI == DNI).FirstOrDefault();

            return person;
        }

        #endregion
    }
}
