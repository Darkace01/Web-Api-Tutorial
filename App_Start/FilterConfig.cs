using System.Web;
using System.Web.Mvc;

namespace EmployeeService_AspNetAPIWithSqlServer_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
