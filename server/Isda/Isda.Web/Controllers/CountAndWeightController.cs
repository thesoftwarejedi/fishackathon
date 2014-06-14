using Isda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Isda.Web.Controllers
{
    public class CountAndWeightController : ApiController
    {
        public IEnumerable<CountAndWeightByLongLat_Result> Get()
        {
            var e = new HackathonEntities();
            return e.CountAndWeightByLongLat(DateTime.Now - new TimeSpan(14, 0, 0, 0),
                                            DateTime.Now,
                                            1, 0, 0, 0, 0);
        }
        public IEnumerable<CountAndWeightByLongLat_Result> Get(DateTime start, DateTime end, int precision = 1, 
                                                                decimal lat1 = 0, decimal lng1 = 0, decimal lat2 = 0, decimal lng2 = 0)
        {
            var e = new HackathonEntities();
            return e.CountAndWeightByLongLat(start,
                                            end,
                                            precision,
                                            lat1,
                                            lng1,
                                            lat2,
                                            lng2);
        }

    }
}
