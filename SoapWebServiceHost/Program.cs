using SoapWebService;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SoapWebServiceHost
{
    // http://localhost:8000/SoapWebService/CalculatorService

    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/SoapWebService/");

            // Host
            // Implements Service and the base address for it
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                // Endpoint
                // Recevies/Exposes Interface for interacting with the service host
                // URI/SoapWebService/CalculatorService ???
                                            // Contract,           Binding,               Address
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                // Behaviour
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Open
                selfHost.Open();

                Console.WriteLine("The service is ready.\nPress <ENTER> to terminateService\n");
                Console.ReadLine(); // Waits for input

                // Close
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                // Abort
                Console.WriteLine(ex.Message);
                selfHost.Abort();
            }

        }
    }
}
