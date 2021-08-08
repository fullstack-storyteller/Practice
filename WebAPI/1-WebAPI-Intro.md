# What is WebAPI

- Web Application Programming Interface = HTTP based services
- ASP .NET WEB API = Framework for building Web API

These services can be consumed by a broad range of clients like:browsers,mobile applications, desktop applications and IOTs (Internet of Things are objects / devices that have an IP address and can communicate with other devices over a network. Examples security systems, electronics appliances, thermostats, desktops, smartphones).

WebAPI is widely used for creating RESTFul services. but it can also be used to create services that are not RESTFul.

## RESTful Services

- REST (Representational State Transfer)
- Introduced by Roy Fielding in 2000
- REST is an architectural pattern for creating services that uses HTTP as its underlying communication method.
- REST specifies the below constrainsts:

  - Client - Server contraint: Client sends request, Server send response. It make separation of logic possible
  - Stateless constraint: We should be not storing anything related to clients at the server end. Each request should contain all the necessary information regarding the client. This ensure each request can be treated independent by the server
  - Cacheble contraint: This states that, let the client know for how long the cached data is good for, so that we can avoid unnecessary processing and significantly imporves system performance.
  - Unform interface contraint: It defines the interface between clients and server. It involves Http verbs(get, put, post, delete) and resources(data entities for example product, employee and customer etc..). The verbs are sent with each request and they tell the server, what needs to be done with the resource.
    | Resource | Verb | Outcome |
    | ----------- | ------ | --------------------------- |
    | /Employees | GET | Gets list of employees |
    | /EMployee/1 | GET | Gets employee with id=1 |
    | /Employee | POST | Creates a new employee |
    | /Employee/1 | PUT | Updates employee with ID =1 |
    | /Employee/1 | DELETE | Deletes employee with ID=1 |

  - Layered System
  - Code on Demand (optional)

### HATEOS (Hypermedia as the Engine of Application State)

In each request there will be a set of hyperlinks, that lets us know what other action can be performed on this resource

## WCF or WEB API

- A lot of configuration is required, especially when we want to create a RESTFul service using WCF. But WEB API are made for Restful Services
- We use WCF when we need a service which is transport or protocol independent. In a WCF, we can have XML over HTTP for interoperability and Binary message or TCP for performance in a single WCF service with multiple end points. Web API can't do this.
- .Net 3.5 or earlier only supports WCF not Web API
- if you have an existing SOAP service you must that you want to add REST to reach more users/clients

### While working with Web API, it will be a good idea to run your Visual Studio in Administrator mode

### executionpolicy in powershel should be set to remoteSigned or allSigned to be able to create a web api project

### For powershell security prompt, press r and hit enter to run once

Note:

| CRUD operations | HTTP Verb |
| --------------- | --------- |
| Create          | POST      |
| Read            | GET       |
| Update          | PUT       |
| Delete          | DELETE    |

## important Points

1. For complete list of HTTP Verbs click [here](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)

2. Request Header contains addtional information about the request. Ex: what type of response is required

3. Request Body contains the data you want to send to server (XML or JSON)

4. Response Body constains the data sent as response from the server

5. Response Status Code provide the client the status of the request. For the complete list of HTTP Status codes click [here](https://www.restapitutorial.com/httpstatuscodes.html)

## Important things in Http requests

1. While issuing POST request, you can specify: `Content-Type: application/json` to send data to server in json format
2. While sending GET request, you can specify: `Accept: application/json` to get response in json format
