using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtension
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            // this will give us the username from the token used to authenticate
            
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}