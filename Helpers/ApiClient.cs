using Microsoft.Extensions.Configuration;
using RestSharp;
using RestsharpAPI_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Helpers
{
    public class ApiClient
    {
        public readonly RestClient restClient;
        public readonly IConfiguration configuration;

        public ApiClient()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("Configuration\\AppSettings.json").Build();
            restClient = new RestClient(configuration["APIUrl"]);
        }


        public RestResponse GetAllPost()
        {
            var request = new RestRequest(configuration["Request_resource"], Method.Get);
            return restClient.Execute(request);
        }

        public RestResponse GetPostById(int id)
        {
            var request = new RestRequest($"{configuration["Request_resource"]}/{id}", Method.Get);
            return restClient.Execute(request);
        }

        public RestResponse CreatePost(PostRequest Post)
        {
            var request = new RestRequest(configuration["Request_resource"], Method.Post);
            return restClient.Execute(request);
        }

        public void DeleteById()
        {

        }


    }
}
