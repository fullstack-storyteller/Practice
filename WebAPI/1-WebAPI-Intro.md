# What is WebAPI

Web Application Programming Interface = HTTP based services
ASP .NET WEB API = Framework for building Web API

These services can be consumed by a broad range of clients like:browsers,mobile applications, desktop applications and IOTs (Internet of Things are objects / devices that have an IP address and can communicate with other devices over a network. Examples security systems, electronics appliances, thermostats, desktops, smartphones).

WebAPI is widely used for creating RESTFul services. but it can also be used to create services that are not RESTFul.

## RESTful Services

- REST (Representational State Transfer)
- Introduced by Roy Fielding in 2000
- REST is an architectural pattern for creating services that uses HTTP as its underlying communication method.
- REST specifies the below constrainsts:
  - Client - Server contraint: Client sends request, Server send responds. It make separation of logic possible
  - Stateless constraint: We should be not storing anything related to clients at the server end. Each request should contain all the necessary informationregarding the client. This ensure each request can be treated independent by the server
  - Cacheble contraint: This states that, let the client know for how long the cached data is good for, so that we can avoid unnecessary processing and significantly imporves system performance.
  - Unform interface contraint:
