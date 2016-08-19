using BRS.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BRS.Web.Areas.API.Controllers
{
    public class PassengerController : ApiController
    {

        public PassengerRepository repository;

        //TODO: Usar Unity
        public PassengerController()
        {
            this.repository = new PassengerRepository();
        }

        [HttpGet]
        public IHttpActionResult Get(int Id)
        {
            var passengers = repository.FindByIdAsync(Id);

            return Ok(passengers);
        }
    }
}
