﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Hubs;
using ConfigurationLib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClientApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
            this.SignalRSettings = this.Configuration.GetSection("signalR").Get<SignalRSection>();
        }

        private readonly IConfiguration Configuration;
        private readonly SignalRSection SignalRSettings;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton(this.SignalRSettings)

                .AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2)
                ;


            services
                .AddSignalR()
                .AddAzureSignalR(this.SignalRSettings.Service.ConnectionString)
                ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseAzureSignalR(routes =>
            {
                routes.MapHub<HeartbeatHub>("/events/heartbeat");
                routes.MapHub<MessageHub>("/events/message");
            });

            app.UseStaticFiles();
        }
    }
}
