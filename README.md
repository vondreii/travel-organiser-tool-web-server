# travel-organiser-tool-web-server

This is to practice/upskill in Angular, C# .Net Entity Framework and SQL together.

## Purpose:

- View upcoming trips
- Can drill down and view details about each trip (WIP)
- Add/edit/delete trips (WIP)

## How to run C# (hosted on Azure):
- Listens to requests at **https://travel-organiser-tool-web-server.azurewebsites.net/** 
- For example: `https://travel-organiser-tool-web-server.azurewebsites.net/api/location/GetAllRegions`
  
## To run C# (locally):
- Open **travel-organiser-tool-web-server** project using Visual Studio 2022.
    - In `appsetting.json`, change `IsProduction` to false
    - Build the solution
    - Use `dotnet run` or press play so it will run in the backend (localhost:5000) and listen to requests from the UI. 
    - When asked about SSL certificates, say 'Yes' on first screen, then 'No' on second screen.
- Run both **travel-organiser-tool-web-server** and **travel-organiser-tool-ui** applications at the same time.
    - Both applications can't be run on the same port, so there is a CORS policy to allows request from 4200 to the different port, 5000.


## To update the DB:

- Open Visual Studio 2022
- Seed data and table model is created in **ApplicationDbContext.cs**.
- After updating the code, run **dotnet ef migrations add initialCreate<newNo>**, then **dotnet ef database update**.


