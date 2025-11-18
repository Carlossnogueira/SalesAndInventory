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

        if (context.Exception is ErrorOnValidationException)
        {
            var exception = (ErrorOnValidationException)context.Exception;
            var errorResponse = new ResponseErrorJson(exception.Errors);

            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(errorResponse);
        }
        else if(context.Exception is UserNotFoundException)
        {
            var exception = (ErrorOnValidationException)context.Exception;
            var errorResponse = new ResponseErrorJson(exception.Errors);

            context.HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            context.Result = new NotFoundObjectResult(errorResponse);
        }
        else
        {
            ThrowUnknowError(context);
        }
       
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