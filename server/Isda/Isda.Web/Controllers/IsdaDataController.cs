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
        public IEnumerable<DeltaOverTimeByLanding_Result> GetDeltaOverTimeByLanding()
        {
            var e = new HackathonEntities();
            return e.DeltaOverTimeByLanding(DateTime.Now - new TimeSpan(7, 0, 0, 0),
                                            DateTime.Now,
                                            DateTime.Now - new TimeSpan(14, 0, 0, 0),
                                            DateTime.Now - new TimeSpan(7, 0, 0, 0));

        }

        public IEnumerable<DeltaOverTimeByLongLat_Result> GetDeltaOverTimeByLongLat()
        {
            var e = new HackathonEntities();
            return e.DeltaOverTimeByLongLat(DateTime.Now - new TimeSpan(7, 0, 0, 0),
                                            DateTime.Now,
                                            DateTime.Now - new TimeSpan(14, 0, 0, 0),
                                            DateTime.Now - new TimeSpan(7, 0, 0, 0),
                                            1);

        }

        public IEnumerable<CountAndWeightByLongLat_Result> GetCountAndWeightByLongLat()
        {
            var e = new HackathonEntities();
            return e.CountAndWeightByLongLat(DateTime.Now - new TimeSpan(7, 0, 0, 0),
                                            DateTime.Now,
                                            1);

        }

    }
}
