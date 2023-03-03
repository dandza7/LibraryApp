using System.Net;
using System.Text.Json;

namespace LibraryApp.SupportClasses.GlobalExceptionHandler
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                HttpStatusCode httpStatusCode = ExceptionStatusCodeDictionary.GetExceptionStatusCode(ex);

                context.Response.StatusCode = (int)httpStatusCode;
                if (ExceptionStatusCodeDictionary.BadRequestWarningExceptions.Contains(ex.GetType()))
                {
                    var exceptionResult = JsonSerializer.Serialize(new { message = ex.Message });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(exceptionResult);
                    _logger.LogWarning("[BAD REQUEST] " + ex.Message);
                }
                else if (ExceptionStatusCodeDictionary.NoContentInformationExceptions.Contains(ex.GetType()))
                {
                    _logger.LogInformation("[NO CONTENT] " + ex.Message);
                }
                else
                {
                    var exceptionResult = JsonSerializer.Serialize(new { message = ex.Message });
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(exceptionResult);
                    _logger.LogError("[REQUEST INTERUPTED] " + ex.Message);
                }

            }
        }
    }
}
