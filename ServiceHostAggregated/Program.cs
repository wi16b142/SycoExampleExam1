using ServiceDefinitionAggregated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHostAggregated
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceAggregated));
            host.Open();
            Console.WriteLine("Aggreagted data servicehost started.");
            Console.ReadLine();
        }
    }
}
