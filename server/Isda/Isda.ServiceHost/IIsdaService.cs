using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Isda.Data;

namespace Isda.ServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIsdaService" in both code and config file together.
    [ServiceContract]
    public interface IIsdaService
    {
        [OperationContract]
        void SubmitHaulData(
            int landingSiteId, 
            int vesselId, 
            DateTime sampleDateTime,
            DateTime haulDateTime,
            DateTime? trapSetTime,
            int numberOfFisherman,
            string notes,
            decimal? longitude,
            decimal? latitude,
            decimal haulWeight,
            decimal sampleWeight,
            string fishType,
            int[] gear
            );

        [OperationContract]
        Haul[] GetHauls();
    }
}
