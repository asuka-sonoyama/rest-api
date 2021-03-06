using System;
using System.Reflection;

namespace AADB2C.WebAPI.BasicAuth.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}