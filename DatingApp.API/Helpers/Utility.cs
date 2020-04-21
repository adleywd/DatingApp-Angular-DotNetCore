using System.Security.Claims;

namespace DatingApp.API.Helpers
{
    public static class Utility
    {
        public static int GetLoggedUserId(ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}