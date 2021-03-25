# ShopBridge
## How to run the project?

* Run the db script db.sql to create the ShopBridgeDb on your local machine
* Open server explorer in Visual Studio, right click -> properties to get the connection string
* Update the connection string in Appsettings.json and ShopBridgeDbContext
* Check if all the nuget packages are installed and run the project.

- - - -
## Tests

* Test the api, using swagger/postman script shopbridge.postman_collection.
* Another project [ShopBridgeTests](https://github.com/vishnuraom/ShopBridgeTests) is also made but with minimal tests.

- - - -
## Tracking

### Data store design
About 1 hour, just added Category, Db first approach, dotnet cli Scaffolding, some issues with nuget package version mismatches.

### API and service logic
About 2.5 hours, faced some issues with Async WebAPI, Exception handling with void/Task return type etc.

### Unit Test Coverage
About 1.5 hours, used MSTest for first time. It is incomplete.
