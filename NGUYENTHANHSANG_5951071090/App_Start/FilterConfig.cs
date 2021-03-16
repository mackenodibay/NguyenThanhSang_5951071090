using System.Web;
using System.Web.Mvc;

namespace NGUYENTHANHSANG_5951071090
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
