using System;
using FluentAssertions;
using Reqnroll;
using RestSharp;
using RestsharpAPI_Automation.Clients;

namespace RestsharpAPI_Automation.StepDefinitions
{
    
    [Binding]
    public class GetUserDetailsStepDefinitions
    {
        public UserClient? _client;
        private RestResponse? _response;
        private string? _endpoint;


        [Given("I set the API endpoint to {string}")]
        public void GivenISetTheAPIEndpointTo(string endpoint)
        {
            _client = new UserClient(endpoint);
            //_client = new RestClient();
           // _endpoint = endpoint;
        }

        [When("I send a get request for User ID {int}")]
        public void WhenISendAGetRequestForUserID(int userId)
        {
            _response = _client?.GetUserByID(userId);
        }

        [Then("The response status should be {int}")]
        public void ThenTheResponseStatusShouldBe(int expectedStatusCode)
        {
           ((int)_response.StatusCode).Should().Be(expectedStatusCode);
        }

        [Then("the response should contain {string}")]
        public void ThenTheResponseShouldContain(string expectedContent)
        {
            _response?.Content.Should().Contain(expectedContent);
        }
    }
}
