
SignalR-2.x-demo
================

Demos for SignalR 2.0 and upcoming 2.x releases

## 2.0.0
- So many bug fixes
- .NET 4.5 required on server
- OWIN startup
- HubException
- JavaScript send objects
- JavaScript error handling
- JavaScript custom JSON parsing
- Hub unit testability
- Send pre-encoded JSON strings
- Send to User
- Send to Groups & Connections (plural)
- Backwards compatible server (supports old clients)
- Self-host
- CORS & JSONP changes
- Connection init message
- .NET Client uses HttpClient now
- .NET Client Portable Class Library (inc. Xamarin)

## 2.0.x
- Client method callback leak fix
- Client calling stop from callback deadlock fix
- Service Bus scale-out stability fixes
    - Use the latest WindowsAzure.ServiceBus package
    - Set ServiceBusScaleoutConfiguration.TopicCount to >1 when calling UseServiceBus()
    - Use nightly builds of SignalR until the 2.0.x is released
    - Don't send messages >256 KB in size as this can kill the Service Bus connection
- Other stuff that's less interesting but still important https://github.com/SignalR/SignalR/issues?labels=&milestone=33&page=1&state=open

## 2.1+
- Hub method invocation progress via IProgress<T>
- Strong typed hubs (Hub<T>)
- Connection message monitoring
- Other stuff that isn't done yet https://github.com/SignalR/SignalR/issues?labels=&milestone=29&page=1&state=open
