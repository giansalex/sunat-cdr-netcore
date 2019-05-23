using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;
using SunatServices;

namespace Sunat.Cdr.Service
{
    public class CdrService
    {
        private readonly ClaveSol _config;

        public string ServiceUrl { get; set; }

        public CdrService(ClaveSol config)
        {
            _config = config;
        }

        public async Task<statusResponse> GetCdr(string ruc, string tipo, string serie, int numero)
        {
            var myBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

            var myEndpoint = new EndpointAddress(ServiceUrl);
            var credential = new ClientCredentials
            {
                UserName = { UserName = _config.Ruc + _config.User, Password = _config.Password }
            };

            ChannelFactory<billService> myChannelFactory = new ChannelFactory<billService>(myBinding, myEndpoint);
            myChannelFactory.Endpoint.EndpointBehaviors.Add(new SessionHeaderBehavior(credential));

            // Create a channel.
            var client = myChannelFactory.CreateChannel();
            var result = await client.getStatusCdrAsync(new getStatusCdrRequest
            {
                rucComprobante = ruc,
                tipoComprobante = tipo,
                serieComprobante = serie,
                numeroComprobante =  numero
            });
            
            ((IClientChannel)client).Close();
            myChannelFactory.Close();

            return result.statusCdr;
        }
    }
}
