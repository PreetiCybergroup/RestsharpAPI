using RestsharpAPI_Automation.Helpers;
using RestsharpAPI_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestsharpAPI_Automation.Tests
{
    public class LoginTests
    {
        ApiClient _apiClient = new ApiClient();
        [Test]
        public void VerifySuccessResponseCode_UsingGetAllMethods()
        {
            var response = _apiClient.GetAllPost();
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
        }

        [Test]
        public void VerifyPostRequest_UsingPostMethod()
        {
            PostRequest _post = new PostRequest() { id = 11, body = "Hello! from c#", title="checking Restsharp", userId=55};

            var response = _apiClient.CreatePost(_post);

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));
        }
    }
}