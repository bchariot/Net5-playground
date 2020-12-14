For hot reload:
    Delete folders "bin" and "obj" in project first.

	Add to "profiles" in launchSettings.json file:
    "Watch": {
      "commandName": "Executable",
      "executablePath": "dotnet.exe",
      "workingDirectory": "$(ProjectDir)",
      "commandLineArgs": "watch run",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
