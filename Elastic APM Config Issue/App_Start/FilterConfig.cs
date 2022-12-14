using System.Web;
using System.Web.Mvc;

namespace Elastic_APM_Config_Issue
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
