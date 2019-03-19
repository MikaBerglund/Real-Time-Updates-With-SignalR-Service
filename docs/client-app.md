ASP.NET Core Client Application
===============================

[Home](readme.md)

This application is a standard ASP.NET Core application, that was built in Visual Studio 2017 from the standard ASP.NET Core Empty project template. Normally, you would probably use another template, but I've tried to keep things to a minimum so that we can focus on the actual matter in this sample, which is using the [Azure SignalR Service](https://azure.microsoft.com/en-us/services/signalr-service/).


Adding References
-----------------

The first thing you need to do after creating the empty project is adding a few references. We add all of these from [Nuget](https://www.nuget.org).

- [Microsoft.Azure.SignalR.AspNet](https://www.nuget.org/packages/Microsoft.Azure.SignalR.AspNet)