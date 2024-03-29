using System;
using System.Reflection;

namespace EmployeeService_AspNetAPIWithSqlServer_.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}