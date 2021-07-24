# ASP .NET WEb API Content Negotiation

Using **Accept** header the client can specify the format of response they want

- Accept: `application/xml`
- Accept: `application/json`
  By default, it will be `text/html`.

Multiple formatters can also specified in accept header:

- Accept: `application/xml,application/json`
  but incase of multiple formatter the first one from left will be choosen
  So depending on the Accept header value, the server send the response. This is called **content negotiation**
- Accept: `application/xml;q=0.8,application/json;q=0.5`
  Here q denoted quality factors, and we see that quality factor of xml is higher, hence xml formatter will be used.

To convert the generated data to a specific type as request in Accept header, the ASP .Net WEB API uses Formatter (xml/json formatter) i.e. media type formatter

You can also define your custom media type formatter, and ensure that you are only sending a specific format as result.

Check the project: `\GITHUB\Practice\WebAPI\2WebAPIAndDBWithEntity`

## Here are a few point to remember while implementing Post method

- if a method return type is void, by default http status code 204 no content is returned
- when a new item is created, we should be returning status code 201 item created
- With 201 status code we should also include the location i.e.e URI of the newly created item
- when an item is not found, instead of returning NUL and status code 200 OK, return 4040 NOT FOUND status code along with a meaningful message such as "Employee with id=101 not found"

## FromBody and FromUri Attriutes

WebAPI default convention for building parameters

- if the arameter is a simple type like int, bool,double, etc., web api tries to get the value from the URI(either from the route data or query string)
- If the parameter is a complex type like Custmer or Employee etc., Web api tries to get the value from the request body

To change the default parameter binding process use \[FromBody\] and \[FromUri\] attributes

- FromBody will force web api tp get simple types from the request body if declared so
- FromUri will force web api to get complex type data from the uri i.e. Route data or query string
