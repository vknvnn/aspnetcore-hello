using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace resources_server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            
            // JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            // var tokenValidationParameters = new TokenValidationParameters
            // {
            //     ValidateIssuerSigningKey = true,
            //     ValidateIssuer = true,
            //     ValidIssuer = "http://localhost:5000",
            //     IssuerSigningKey = new X509SecurityKey(new X509Certificate2(Path.Combine("cer", "IdentityServer4Auth.cer"), "123456"))
            // };
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:5000";
                    options.RequireHttpsMetadata = false;                    
                    options.ApiName = "api1";
                    options.ApiSecret = "123";
                    //options.SecurityTokenValidators 
                });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
