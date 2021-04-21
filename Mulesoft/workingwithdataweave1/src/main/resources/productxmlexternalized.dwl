/* %dw 2.0
output application/xml
---
{
	pid: payload.productId,
	pname: payload.name
}
*/

%dw 2.0
output application/xml
---
product @(pid:payload.productId):{ //use @(the element which needs to be the atrribute of xml tag): 
	
//	pid: payload.productId, //make this an attribute of xml tag 
	
	pname: payload.name,
	imgs: payload.images[1]
}
