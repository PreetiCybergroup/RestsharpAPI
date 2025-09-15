Feature: Get User Details

A short summary of the feature

@tag1
Scenario Outline: Verify user details by ID
	Given I set the API endpoint to "<BaseUrl>"
	When I send a get request for User ID <UserId>
	Then The response status should be 200
	And  the response should contain "<ExpectedName>"
Examples: 
  | BaseUrl                               | UserId | ExpectedName   |
  | https://jsonplaceholder.typicode.com  | 1      | Leanne Graham  |
  | https://jsonplaceholder.typicode.com  | 2      | Ervin Howell   |

