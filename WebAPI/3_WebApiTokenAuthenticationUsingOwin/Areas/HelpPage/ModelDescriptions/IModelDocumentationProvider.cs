using System;
using System.Reflection;

namespace _3_WebApiTokenAuthenticationUsingOwin.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}