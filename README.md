Football Match App


The Football Match App is a web application that streams random football match data using a .NET Core backend with SignalR for real-time updates. This README provides instructions for running both the backend and frontend of the application.

Prerequisites
Before running the application, make sure you have the following prerequisites installed:

- Node.js and npm
- .NET 6
- Angular CLI (for the frontend)

Backend (API)
The backend of the Sample Timing Football Match App is built using .NET Core 6 and provides a Web API to stream random football match data. To run the backend:

Open a terminal or command prompt.

Navigate to the backend directory:


cd backend
Restore the .NET packages:


dotnet restore
Build the backend:


dotnet build
Run the backend application:


dotnet run
The API will be hosted at https://localhost:7068/ (HTTPS) 

You can run the swagger directly to start streaming the data https://localhost:7068/swagger/index.html

Frontend (Angular App)
The frontend of the Football Match App is built using Angular and consumes the data from the backend API. To run the frontend:

Open a new terminal or command prompt (while keeping the backend running).

Navigate to the frontend directory:


cd frontend
Install the project's dependencies:


npm install
Start the Angular development server:


ng serve
Open a web browser and visit http://localhost:4200 to access the Football Match App.

Using the App
Once the application is running, you can click the "Start Streaming" button to begin receiving real-time football match data from the backend.
The app will display the most recent football matches, limited to 5 entries.
Stopping the App
To stop the application, press Ctrl + C in the terminal where the backend or frontend is running.
Configuration
You can configure the backend SignalR hub URL in the frontend/src/app/football-match.service.ts file. Replace the URL with your backend's SignalR hub URL if needed.
