> This sample is not yet complete. You can add a watch on this repo to get notified when I update it, so stay tuned!



# Real-Time Updates With Azure SignalR Service
A sample project that demonstrates how you can feed in events to Azure SignalR Service from virtually any source and shown them to connected web clients.

> The sample is written entirely for .NET Core using Visual Studio 2017. Since it is .NET Core, you should also be able to use the code if you are using Visual Studio Code. Even though I love the direction Visual Studio Code is going to, I still feel I am more productive on Visual Studio.

Read more about this sample in the [docs](./docs).


Benefits of Using the SignalR Service
-------------------------------------

It's perfectly fine to host the SignalR runtime in for instance your ASP.NET Core application and have all clients connected to your application publish and receive events completely without the [SignalR Service](https://azure.microsoft.com/en-us/services/signalr-service/).

However, when you have a situation where your event sources are different from the client applications, or you have multiple client applications, the the SignalR Service can provide a lot of value, since you connect your event sources and consumers to the service, and not your ASP.NET Core host, for instance.

This is one of the biggest benefits I think the [Azure SignalR Service](https://azure.microsoft.com/en-us/services/signalr-service/) brings to the table.


Contribute
----------

Please feel free to send me pull requests in case you think something is wrong or missing. Keep in mind though that I want this sample to be as simple as possible in order to give a better understanding of the use cases and capabilities of [Azure SignalR Service](https://azure.microsoft.com/en-us/services/signalr-service/), and not be complete demonstration of all features of the service.

Of course you could always fork this repo and build and extend this sample in any way you see purposeful.