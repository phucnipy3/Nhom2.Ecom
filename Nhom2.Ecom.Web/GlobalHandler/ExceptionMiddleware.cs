using Microsoft.AspNetCore.Http;
using Nhom2.Ecom.Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom2.Ecom.Web.GlobalHandler
{
    public class ExceptionMiddleware : IMiddleware
    {

        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                Logging<ExceptionMiddleware>.Error(ex);
                httpContext.Response.Redirect("/Error/InternalServerError");
            }
        }
    }
}
