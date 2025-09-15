Feature: Get User Details

A short summary of the feature

@tag1
Scenario: Verify user details by ID
	Given I set the API endpoint to "https://jsonplaceholder.typicode.com/"
	When I send a get request for User ID 1
	Then The response status should be 200
	And  the response should contain "Leanne Graham"
