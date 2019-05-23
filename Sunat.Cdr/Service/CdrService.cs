using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;
using SunatServices;

namespace Sunat.Cdr.Service
{
    public class CdrService
    {
        private readonly string _ruc;
        private readonly string _user;
        private readonly string _password;

        public CdrService(string ruc, string user, string password)
        {
            _ruc = ruc;
            _user = user;
            _password = password;
        }

        public async Task<statusResponse> GetCdr(string ruc, string tipo, string serie, int numero)
        {
            var myBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

            var myEndpoint = new EndpointAddress("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService");
            var credential = new ClientCredentials
            {
                UserName = { UserName = _ruc + _user, Password = _password }
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
