Feature: GoogleSearch
	Open a browser then navigate to Google.com

@googlesearch
Scenario: Browse to Google
	Given I go to http://www.google.com
	Then I should type Hello in the searchbox
	Then I clear the searchbox
	Then I should type Google in the searchbox
	Then I press enter
	Then I check if the Google logo is in the search page
	Then I take a screenshot of the page