# Transaction API Application


# Project Type
	Asp.net core web api (C#/.net 7)

# Environment and Packages needed - Manage NuGet Packages to install
	1. Visual Studio
	2. Newtonsoft.json for JSON deserialization

# UI to check API
	No additional setup / installation / packages needed for UI to test API
	In Visual Studio, running the project will bring up SwaggerUI (SwaggerUI is built in).
	For documentation regarding SwaggerUI: https://swagger.io/tools/swagger-ui/

# Testing notes
	1. Functionality for find by Id and find by Account Number is complete
	2. Functionality for find by IsBetween dateRange partially implemented.  Need to do
	proper conversions and formatting of dates before comparison.

# Planning
	1. Insert transactions.json file into project
	2. Create Model to model the JSON data
	3. Create controller with Get request mapping
		- One route for Get One By ID
			- Deserialize JSON into a List<Transaction> and iterate through list to match Id
			- Return HttpStatus "Ok" and Transaction object if present
			- Return HttpStatus "NotFound" if Transaction object is NOT present
		- One route for Get All by AccountNumber
			- Deserialize JSON into a List<Transaction> and iterate through list, adding each item 
			  matching the AccountNumber to the list
			- Return HttpStatus "Ok" and List<Transaction> if list is not empty
			- Return HttpStatus "NotFound" if list is empty

# End Result / Roadblocks / Final Thoughts
	C#/.net is new to me. My experience is with Java and JavaScript. This was a nice challenge
	to translate what I know about other languages and frameworks to the C#/.net ecosystem.

	JSON file had a key that started with a $. That is not valid c# syntax so it took some time
	to figure out how to address this issue. Ended up doing a find and replace all in the JSON file
	to change the key from "$id" to "DollarSignId".

	Thought deserialization of JSON file wasn't working. Initially tried to create a get all
	Transactions route just to get something going as a baseline. The Swagger UI would stall.
	Finally figured out that it was just too much data for the UI to display and it would hang.
	Troubleshooted by double checking to make sure the Transaction model was correct, comparing
	to the JSON file. Eventually just set a breakpoint and checked the List of Transactions and
	it was in fact deserializing and adding to a list. Also ended up using a popular JSON package
	instead of the default implementation of deserialization.

	If time permitted, I would have created custom Exception classes and added a Logger for any issues
	with the deserialization of the JSON. Also would have created tests.
