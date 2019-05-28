using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Organizer_UI.Filter
{
    public class MyAuthenticationFilter: ActionFilterAttribute,IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["User"]==null)
            {
                filterContext.Result = new RedirectResult("~/Home/Hata");
            }
        }
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

        }
    }
}