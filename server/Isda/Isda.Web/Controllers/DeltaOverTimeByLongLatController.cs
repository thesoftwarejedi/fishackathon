using Isda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Isda.Web.Controllers
{
    public class DeltaOverTimeByLongLatController : ApiController
    {

        public IEnumerable<DeltaOverTimeByLongLat_Result> Get(DateTime start1, DateTime end1, DateTime start2, DateTime end2, int precision = 1, 
                                                                decimal lat1 = 0, decimal lng1 = 0, decimal lat2 = 0, decimal lng2 = 0)
        {
            var e = new HackathonEntities();
            return e.DeltaOverTimeByLongLat(start1,
                                            end1,
                                            start2,
                                            end2,
                                            precision,
                                            lat1,
                                            lng1,
                                            lat2,
                                            lng2);
        }

    }
}
