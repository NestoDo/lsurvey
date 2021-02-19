using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.Survey.Api.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SL.Survey.Api.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IIdentityService, IdentityService>();

            services.AddMvc();
        }
    }
}
