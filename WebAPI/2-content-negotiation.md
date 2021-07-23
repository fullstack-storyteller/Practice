# ASP .NET WEb API Content Negotiation

Using **Accept** header the client can specify the format of response they want

- Accept: `application/xml`
- Accept: `application/json`
  By default, it will be text/html.

Multiple formatters can also specified in accept header:

- Accept: `application/xml,application/json`
  but incase of multiple formatter the first one from left will be choosen
  So depending on the Accept header value, the server send the response. This is called **content negotiation**
- Accept: `application/xml;q=0.8,application/json;q=0.5`
  Here q denoted quality factors, and we see that quality factor of xml is higher, hence xml formatter will be used.

To convert the generated data to a specific type as request in Accept header, the ASP .Net WEB API uses Formatter (xml/json formatter) i.e. media type formatter
