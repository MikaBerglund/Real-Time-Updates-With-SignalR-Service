Real-Time Updates with SignalR Service
======================================

This is a sample project that I created for myself to try out the [Azure SignalR Service](https://azure.microsoft.com/en-us/services/signalr-service/) with a setup that is as simple as possible. The main focus in this sample is to demonstrate the ability to easily feed in events from virtually anywhere, and have the *SignalR Service* then distribute those events to connected clients. In my opinion this is one of the biggest benefits of the service compared to hosting *SignalR* yourself, in a web application for instance.


The Client Application
----------------------

The data published through the *SignalR Service* is displayed in a simple [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) application, where the server-side configuration is modified to connect to the *SignalR Service*. The client-side part of this application connects to the server-side *SignalR* hub.

[Read more about the client application](client-app.md).

The Event Source
----------------

To demonstrate how to feed the *SignalR Service* with events from virtually any source, I've created a separate [Azure Functions](https://docs.microsoft.com/en-us/azure/azure-functions/functions-overview) application, which contains several functions that feed in data to the SignalR Service, both automatically on a schedule as well as on-demand, in response to HTTP requests.

With the same mechanism, you could then use any [Azure Functions binding](https://docs.microsoft.com/en-us/azure/azure-functions/functions-triggers-bindings#supported-bindings) that supports triggering to trigger a function that would feed in event data into the SignalR Service. If a service or technology is not on that list, then there's a big chance that you could use the [HTTP & Webhook triggers](https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook) to get data from more or less any system.

[Read more about the event source application](event-source.md).


Disclaimer
----------

> Please remember that by the time of writing (late March 2019), the *Azure SignalR Service* is still in preview, and so are all SDKs and other class libraries related to the service.