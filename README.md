# nuCypherNetworkGUI

Simple UI prototype for nuCypher network.
Application can be started on Windows, Linux, macOS

## Idea:

Create cross platform desktop application. Easy to deploy with minimum or nothing setup actions.
Ready build sample for Win64 in builds folder.

## How:

Brief - Use Electron.Net (https://github.com/ElectronNET/Electron.NET)

More detailed:

"Electron.NET is a wrapper around a "normal" Electron application with an embedded ASP.NET Core application. Via our Electron.NET IPC bridge we can invoke Electron APIs from .NET." (c)

We can use usual .Net Core ASP.Net MVC to build a desktop application.

* Development environment setup:
  * Need .Net Core (2.0 for this sample)
  * Node.js 8.6.0 or above.
  I recommend use nvm for Node install
  
  If You have a problem with self signed certificate, try this in console:
  "npm config set strict-ssl false"
  
  If You have a problem with electron install, try this
  "npm install electron -g"
  
* Use command in project folder:
    * dotnet restore
    * dotnet electronize init
    * dotnet electronize start

* Build application:
  * from project folder run: dotnet electronize build /target win
  * from project folder run: dotnet electronize build /target linux
  * from project folder run: dotnet electronize build /target osx (only on Linux or macOS)
  * go to output path (look at console)
  * run .exe file
  
 ## Screens:
 
 ![nuCypher GUI Logon](/screens/logon.png)
 
 ![nuCypher GUI Logon](/screens/Dashboard.png)
 
 ![nuCypher GUI Logon](/screens/Bids.png)
 
 ![nuCypher GUI Logon](/screens/Settings.png)
