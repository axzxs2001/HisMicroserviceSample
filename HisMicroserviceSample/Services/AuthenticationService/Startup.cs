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
using JWTAuthorizePolicy;

namespace AuthenticationService
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

            services.AddOcelotPolicyJwtBearer(audienceConfig["Issuer"], audienceConfig["Issuer"], audienceConfig["Secret"], "GSWBearer", "Permission", "/hisapi/denied");

            //注入OcelotJwtBearer
            services.AddJTokenBuild(audienceConfig["Issuer"], audienceConfig["Issuer"], audienceConfig["Secret"], "/api/denied");
            services.AddMvc();
        }
      
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
