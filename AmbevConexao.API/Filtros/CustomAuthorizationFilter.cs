using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AmbevConexao.API.Filtros
{
    public class CustomAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var headers = context.HttpContext.Request.Headers;

            if (!headers.ContainsKey("Ambev"))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
