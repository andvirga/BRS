using BRS.Data.Repository;
using BRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace BRS.Web.Controllers
{
    public class PassengerAPIController : ApiController
    {
        private PassengerRepository repository { get; set; }

        public PassengerAPIController()
        {
            this.repository = new PassengerRepository();
        }

        public JsonResult<List<Passenger>> Get()
        {
            var passengers = this.repository.GetAll();
            return Json(passengers);
        }

        public async Task<IHttpActionResult> Post(Passenger p)
        {
            p = new Passenger();
            p.City = "Rosario";
            p.Country = "Argentina";
            p.DayOfBirth = DateTime.Now;
            p.DNI = "1111111";
            p.Email = "abc@def.com";
            p.FirstName = "Juan";
            p.LastName = "Perez";
            p.PrimaryAddress = "Avenida";
            p.PrimaryPhone = "123456789";
            p.Province = ProvinceEnum.Santa_Fe;
            p.TravelHistory = "bla bla bla";

            try
            {
                await this.repository.CreateAsync(p);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }
    }
}
