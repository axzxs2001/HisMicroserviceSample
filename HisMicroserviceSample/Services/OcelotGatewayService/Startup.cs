using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using JWTAuthorizePolicy;

namespace OcelotGatewayService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            var audienceConfig = Configuration.GetSection("Audience");
            //注入OcelotJwtBearer
            services.AddOcelotJwtBearer(audienceConfig["Issuer"], audienceConfig["Issuer"], audienceConfig["Secret"], "GSWBearer");

            //注入Ocelot
            services.AddOcelot(Configuration);
        }

     
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {           
            //使用中间件
            await app.UseOcelot();
        }
    }
}
