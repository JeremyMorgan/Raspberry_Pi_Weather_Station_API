using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherCenter.Models;
using WeatherCenter.Helpers;
using System.Web.Http.Cors;

namespace WeatherCenter.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReadingController : ApiController
    {
        // GET: api/Reading
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reading/5
        public List<Reading> Get(int id)
        {
            //var ReturnList = new List<Reading>();

            var ourReadingHandler = new ReadingHandler();



            return ourReadingHandler.GetReadings(id);

        }

    }
}
