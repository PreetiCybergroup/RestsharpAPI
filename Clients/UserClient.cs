using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Clients
{
    public class UserClient
    {
        RestClient _restClient;
        public UserClient(string baseUrl)
        {
            var options = new RestClientOptions(baseUrl)
            {
                ThrowOnAnyError = false,
                RemoteCertificateValidationCallback = (sender, cert, chain, errors) => true
            };
            _restClient = new RestClient(options);
        }


        public RestResponse GetUserByID(int id)
        {
            var request = new RestRequest($"/users/{id}", Method.Get);
            return  _restClient.Execute(request);
        
        }
    }
}
