using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TFGPlastic.Web.Utils
{
    public class AuthenticatedUser
    {
        public static bool IsAuthenticated(HttpContext context)
        {            
            var isAuthenticated = context.Session.GetString(ConstantsTFG.AUTHETICATION_COOKIE);

            if (isAuthenticated != ConstantsTFG.AUTHETICATION_TRUE)
            {
                return true;
            }
            return false;
        }
    }
}
