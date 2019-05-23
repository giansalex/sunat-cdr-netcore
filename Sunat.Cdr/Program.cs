using System;
using System.ServiceModel;
using System.Threading.Tasks;
using SunatServices;

namespace Sunat.Cdr
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();
            
    
            EndpointAddress myEndpoint = new EndpointAddress("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService");

            ChannelFactory<billService> myChannelFactory = new ChannelFactory<billService>(myBinding, myEndpoint);

            // Create a channel.
            var wcfClient1 = myChannelFactory.CreateChannel();
            var s = await wcfClient1.getStatusCdrAsync(new getStatusCdrRequest
            {
                numeroComprobante =  1
            });
            
            Console.WriteLine(s.statusCdr.statusMessage);

            ((IClientChannel)wcfClient1).Close();
            
            
        }
    }
}
