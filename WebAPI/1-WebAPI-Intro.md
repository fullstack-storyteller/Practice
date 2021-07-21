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
  - Layered System
  - Code on Demand (optional)
  - Unform interface contraint: It defines the interface between clients and server. It involves Http verbs(get, put, post, delete) and resources(data entities for example product, employee and customer etc..). The verbs are sent with each request and they tell the server, what needs to be done with the resource.
    | Resource | Verb | Outcome |
    | ----------- | ------ | --------------------------- |
    | /Employees | GET | Gets list of employees |
    | /EMployee/1 | GET | Gets employee with id=1 |
    | /Employee | POST | Creates a new employee |
    | /Employee/1 | PUT | Updates employee with ID =1 |
    | /Employee/1 | DELETE | Deletes employee with ID=1 |

### HATEOS (Hypermedia as the Engine of Application State)

In each request there will be a set of hyperlinks, that lets us know what other action can be performed on this resource
