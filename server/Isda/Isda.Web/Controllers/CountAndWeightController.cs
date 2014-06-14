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
                                            1);
        }
        public IEnumerable<CountAndWeightByLongLat_Result> Get(DateTime start, DateTime end, int precision = 1)
        {
            var e = new HackathonEntities();
            return e.CountAndWeightByLongLat(start,
                                            end,
                                            precision);
        }

    }
}
