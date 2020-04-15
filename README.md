# DatingApp-Angular-DotNetCore
This is a sample project with Angular and .NetCore.

# Configuration
## Api

add in root API folder appsettings.json and appsettings.Development.json the following code:

```
{  
  "AppSettings": {
    "Token": "super secret key"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=datingapp.db"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "Microsoft": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "CloudinarySettings": {
    "CloudName": "xxxx",
    "ApiKey": "xxxx",
    "ApiSecret": "xxxx"
  }
}
```
