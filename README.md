HNG12 Backend API - Stage Zero

This is a simple API created as part of the HNG12 internship. It returns basic information such as the registered email address, the current date and time in ISO 8601 format, and the GitHub repository URL.

The goal of this project is to create an endpoint that serves this information in a well-structured JSON response.
Setup Instructions

Clone this repository:

git clone https://github.com/medusa009/HNGStageZero.git

Navigate to the project directory:

cd HNGStageZero

Restore dependencies:

dotnet restore

Run the project:

dotnet run

    Visit https://hngstagezero-1.onrender.com/api/HNG12 to view the API in action.

API Documentation
Endpoint: GET [api/HNG12]
Request:

No request body is needed.
Response:

A JSON object containing:

    email: My registered email address
    current_datetime: The current date and time in ISO 8601 format (UTC)
    github_url: The URL of the GitHub repository

Example Response:

{
 "email": "agentsmith27@proton.me",
  "timestamp": "2025-01-31T20:21:50.4571848Z",
  "github": "https://github.com/medusa009/HNGStageZero"
}

Backlink:
https://hng.tech/hire/csharp-developers

