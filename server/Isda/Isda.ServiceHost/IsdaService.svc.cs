using System;
using System.Linq;
using System.Net;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Isda.Data;

namespace Isda.ServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IsdaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IsdaService.svc or IsdaService.svc.cs at the Solution Explorer and start debugging.
    public class IsdaService : IIsdaService
    {
        public void SubmitHaulData(int landingSiteId, int vesselId, DateTime sampleDateTime, DateTime haulDateTime, DateTime? trapSetTime, int numberOfFisherman, string notes, decimal? longitude, decimal? latitude, decimal haulWeight, decimal sampleWeight, string fishType, int[] gear)
        {
            var haul = new Haul()
            {
                LandingSiteId = landingSiteId,
                VesselId = vesselId,
                SamplingDateTime = sampleDateTime,
                HaulDateTime = haulDateTime,
                TrapSetDateTime = trapSetTime,
                NumberOfFisherman = numberOfFisherman,
                Notes = notes,
                Longitude = longitude,
                Latitude = latitude,
                HaulWeight = haulWeight,
                SampleWeight = sampleWeight
            };

            using (var dal = new HackathonEntities())
            {
                dal.Hauls.Add(haul);

                if (dal.SaveChanges() == 0)
                {
                    throw new WebFaultException<string>("Data not saved", HttpStatusCode.InternalServerError);
                }
            }

            //try
            //{
                
            //}
            //catch (Exception ex)
            //{
            //    throw new WebFaultException<string>("Bar wasn't Foo'd", HttpStatusCode.BadRequest);
            //    return (int)HttpStatusCode.InternalServerError;
            //}
            
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        public Haul[] GetHauls()
        {
           return new Haul[]
           {
               new Haul(){HaulId = 1, FishType = "pops"}, 
               new Haul(){HaulId = 2, FishType = "pops2"}
           };
        }
    }
}
