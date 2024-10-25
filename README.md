# Project LeaderBoard API Documentation

## Overview
The LeaderBoard project provides a RESTful API for managing teams and counters. This API allows users to create, update, delete teams and counters, as well as retrieve team statistics. It utilizes the Mediator pattern for handling commands and queries.

## API Endpoints

### Create or Update Team
```http
POST /CreateOrUpdateTeam
Description: Creates a new team or updates an existing one.
Parameters:
teamCommand: The command object containing team details (passed as a query parameter).
Response: Returns the created or updated team object.
POST /CreateCounter
Description: Creates a new counter for tracking steps.
Parameters:
createCounterCommand: The command object with counter details (passed as a query parameter).
Response: Returns the created counter object.
POST /IncrementCounter
Description: Increments the value of an existing counter.
Parameters:
incrementCounterCommand: The command object containing the counter ID and the increment value (passed as a query parameter).
Response: Returns the updated count of the specified counter.
GET /GetTeamTotalSteps
Description: Retrieves the total steps for a specific team.
Parameters:
getTeamCountersQuery: The query object containing the team ID (passed as a query parameter).
Response: Returns the total steps for the specified team.
GET /GetTeamSteps
Description: Retrieves steps for all teams.
Parameters:
getAllTeamsQuery: The query object for retrieving all teams (passed as a query parameter).
Response: Returns a list of all teams and their respective steps.
DELETE /DeleteTeam
Description: Deletes a specified team.
Parameters:
deleteTeamCommand: The command object containing the team ID to be deleted (passed as a query parameter).
Response: Returns confirmation of the deleted team.

DELETE /DeleteCounter
Description: Deletes a specified counter.
Parameters:
deleteCounterCommand: The command object containing the counter ID to be deleted (passed as a query parameter).
Response: Returns the total steps remaining after deletion.
````


## Installation and Setup

git clone https://github.com/blessingjarawani/LeaderBoard.git

Install Dependencies: Follow the instructions to install necessary packages depending on your project setup, such as using NuGet for .NET dependencies.

Run the Application:
dotnet run

Access the API: Open your browser and navigate to http://localhost:7247 (or the specified port) to access the API.

Usage
You can use tools like Postman or cURL to interact with the API endpoints.



