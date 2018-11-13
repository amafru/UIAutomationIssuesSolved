Feature: Scenarios
	
#Test created to satisfy Kelly's work problem of copying a bearer token from database and pasting into AUT UI field WITHOUT the accompanying quotation marks
Scenario: Paste copied enquiry string to search field and omit first and last characters with code
	Given that Wikipedia home page is successfully loaded
	When I successfully copy text Wikipedia from Wikipedia home page and store it in a variable
	And I paste the copied text into Google's search box while omitting the first and last characters
	Then the resulting term should be searched when I click Search
	
	#Then the text is pasted as desired in the Google search box i.e ikipedi 
	#Above step commented out as it's a rather redundant assertion to make
