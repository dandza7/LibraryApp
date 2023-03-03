using System.Security.Claims;

namespace LibraryApp.SupportClasses.MyExtensions
{
    public static class MyExtensions
    {
        public static string GetEmail(this ClaimsPrincipal claims)
        {
            return claims.FindFirstValue(ClaimTypes.Email);
        }
    }
}
