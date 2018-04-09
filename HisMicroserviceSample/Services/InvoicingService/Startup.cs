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

namespace InvoicingService
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

            //读取配置文件
            var audienceConfig = Configuration.GetSection("Audience");
            services.AddOcelotPolicyJwtBearer(audienceConfig["Issuer"], audienceConfig["Issuer"], audienceConfig["Secret"], "GSWBearer", "Permission", "no permission");
            //这个集合模拟用户权限表,可从数据库中查询出来
            var permission = new List<Permission> {
                              new Permission {  Url="/", Name="system"},
                              new Permission {  Url="/api/values", Name="system"}
                          };
            services.AddSingleton(permission);
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
