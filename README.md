# **Factory**

### By _Max Betich_

## Technologies Used

* _C#/.NET v6_
* _HTML_
* _CSS_
* _Bootstrap_
* _MySQL 8.0_

## Description
This application uses a database to support a website that allows the user to maintain lists of registered machines and engineers at a factory, and enables them to see and modify the details and relationships between each element.

## Setup/Installation Requirements
* Clone project from this [GitHub repository](https://github.com/MaxBetich/factory.git) to your desktop.
* Navigate to the Factory directory inside this repo in your terminal and create a new file called `appsettings.json`.
* Within `appsettings.json` put in the following code, replacing the `[UID HERE]` and `[PWD HERE]` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[UID HERE];pwd=[PWD HERE];"
  }
}
```
* Run the command `dotnet restore` in your terminal to initialize the program.
* Run the command `dotnet ef database update` after ensuring your MySQL workbench is running to create the project database.
* Within the Factory directory run `dotnet watch run` in the terminal to start the program in your default browser.
 
## Known Bugs

None

## License

MIT

Copyright (c) _2023_ _Max Betich_