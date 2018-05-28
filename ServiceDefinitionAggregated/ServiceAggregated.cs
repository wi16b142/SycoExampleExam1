using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataRepository;
using Shared;

namespace ServiceDefinitionAggregated
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceAggregated : IServiceAggregated
    {
        DataHandler dh = new DataHandler();
        public List<AggregatedPerson> GetAggregatedPersonData()
        {
            return dh.GetAggregatedPersonData();
        }
    }
}
