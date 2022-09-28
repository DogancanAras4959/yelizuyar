using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yelizuyar.ENGINES.Engines;
using yelizuyar.ENGINES.Interface;

namespace yelizuyar.Core
{
    internal static class RegisterInjection
    {
        internal static void AddInjections(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient(typeof(IEmailSender), typeof(EmailSender));

        }
    }
}
