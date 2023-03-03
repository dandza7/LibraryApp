using LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using System.Net;

namespace LibraryApp.SupportClasses.GlobalExceptionHandler
{
    public static class ExceptionStatusCodeDictionary
    {
        private static Dictionary<Type, HttpStatusCode> exceptionStatusCodes = new Dictionary<Type, HttpStatusCode>
        {
            {typeof(Exception), HttpStatusCode.InternalServerError},
            {typeof(NotFoundException), HttpStatusCode.NotFound},
            {typeof(BadCredentialsException), HttpStatusCode.BadRequest},
            {typeof(EmailNotUniqueException), HttpStatusCode.BadRequest},
            {typeof(NoAvatarFoundException), HttpStatusCode.NoContent },
            {typeof(EmptyCollectionException), HttpStatusCode.NoContent }
        };
        public static Type[] BadRequestWarningExceptions =
        {
            typeof(NotFoundException),
            typeof(BadCredentialsException),
            typeof(EmailNotUniqueException)
        };
        public static Type[] NoContentInformationExceptions =
        {
            typeof(NoAvatarFoundException),
            typeof(EmptyCollectionException)
        };

        public static HttpStatusCode GetExceptionStatusCode(Exception ex)
        {
            bool exceptionFound = exceptionStatusCodes.TryGetValue(ex.GetType(), out var statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
