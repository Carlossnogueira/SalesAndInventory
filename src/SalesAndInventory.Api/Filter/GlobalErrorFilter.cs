using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SalesAndInventory.Communication.Response;
using SalesAndInventory.Exception;

namespace SalesAndInventory.Api.Filter;


public class GlobalErrorFilter : IExceptionFilter
{
    private readonly IWebHostEnvironment _environment;

    public GlobalErrorFilter(IWebHostEnvironment environment)
    {
        _environment = environment;
    }


    public void OnException(ExceptionContext context)
    {
        if (context.Exception is SalesAndInventoryException)
        {
            HandleProjectException(context);
        }
        else
        {
            ThrowUnknowError(context);
        }

        context.ExceptionHandled = true;
    }

    private void HandleProjectException(ExceptionContext context)
    {
        var salesAndInventoryException = (SalesAndInventoryException)context.Exception;
        var errorResponse = new ResponseErrorJson(salesAndInventoryException.GetErrors());
        context.HttpContext.Response.StatusCode = salesAndInventoryException.StatusCode;
        context.Result = new ObjectResult(errorResponse);
    }
    
    private void ThrowUnknowError(ExceptionContext context)
    {
        if (_environment.IsDevelopment())
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new BadRequestObjectResult(context.Exception.Message);
        }

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new BadRequestObjectResult("Internal Server Error" + context.Exception.Message);
    }
}