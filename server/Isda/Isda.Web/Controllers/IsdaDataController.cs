using Isda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Isda.Web.Controllers
{
    public class IsdaDataController : ApiController
    {
        // GET api/isdadata
        public IEnumerable<DeltaOverTimeByLanding_Result> Get()
        {
            var e = new HackathonEntities();
            return e.DeltaOverTimeByLanding(DateTime.Now - new TimeSpan(7, 0, 0, 0),
                                            DateTime.Now,
                                            DateTime.Now - new TimeSpan(14, 0, 0, 0),
                                            DateTime.Now - new TimeSpan(7, 0, 0, 0));

        }

    }
}
