English-Hungarian Dictionary
This project is a simple web-based dictionary application that allows users to translate English words or phrases into Hungarian. The application is built using React for the frontend and **.NET Core** for the backend.

Features
- Translation: The application allows users to input an English word and get the Hungarian translation.
- Backend API: A RESTful API built with .NET Core retrieves translations from a SQL Server database.
- Frontend UI: A user-friendly interface built with React and Bootstrap, where users can enter a word and get the translation.

Tech Stack
- Frontend:
  - React.js
  - Bootstrap 4/5
  - Axios (for API requests)
  
- Backend:
  - .NET Core (ASP.NET Core Web API)
  - SQL Server (Database)

 Getting Started
To get started with this project locally, follow these steps:
Prerequisites

- React.js (for the frontend)
- .NET Core SDK (for the backend)
- MSSQL Server (for the database)

Backend Setup

1. Clone this repository:
   git clone https://github.com/GhubSagar/English-Hungarian-Dictionary.git
   
Navigate to the backend directory (DictionaryAPI):
cd DictionaryAPI

Install the required packages:
dotnet restore

Create the database and import the data:
Run the SQL commands from DatabaseSetup.sql to set up your SQL Server database.
Run the backend:
dotnet run
The backend API will be running at http://localhost:5188.

Frontend Setup

Navigate to the frontend directory (DictionaryFrontend):
cd DictionaryFrontend

Install the required packages:
npm install

Start the frontend application:
npm start

The frontend application will be running at http://localhost:3000.

CORS Policy
Ensure that the backend API allows cross-origin requests from the frontend by setting up CORS in the DictionaryAPI project.

Environment Variables
If you want to manage your API URL dynamically, you can create a .env file in the DictionaryFrontend project with the following:



Acknowledgements
Bootstrap for responsive UI components.
.NET Core for building the API.
React for the frontend framework.
