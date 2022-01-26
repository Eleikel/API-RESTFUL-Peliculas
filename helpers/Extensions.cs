using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeliculas.helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string mesage)
        {
            response.Headers.Add("Application-Error", mesage);
            response.Headers.Add("Acces-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Acces-Control-Allow-Origin", "*");

        }

    }
}
