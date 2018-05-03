using System;
using System.Reflection;

namespace Gstt.Hack.Api.DocumentMetaData.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}