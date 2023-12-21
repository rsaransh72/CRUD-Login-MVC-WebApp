using System.Web;
using System.Web.Mvc;

namespace CRUD_Login_MVC_WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
