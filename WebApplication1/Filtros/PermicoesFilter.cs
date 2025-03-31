using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.Filtros
{
    public class PermissoesFilters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Cookies["login"] == null)
            {
                // Usando Result para redirecionar
                filterContext.Result = new RedirectResult("~/Home/Login2");
            }
        }
    }
}
