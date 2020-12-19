using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kalendarz_Telekonferencji.Areas.Identity;
using Kalendarz_Telekonferencji.Data.Interfaces;
using Kalendarz_Telekonferencji.Data;
using CalendarDatabase;
using CalendarDatabase.Interfaces;
using CalendarDatabase.Repository;
using Kalendarz_Telekonferencji.Mapper;

namespace Kalendarz_Telekonferencji
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CalendarDBContextDatabase>(options => options.UseSqlServer("Server=DESKTOP-DOSSHB6\\SQLEXPRESS;Database=CalendarDB;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<CalendarDBContextDatabase>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddScoped<IFileUpload, FileUploadServices>();
            services.AddScoped<ICalendarRepository, CalendarRepository>();
            services.AddScoped<ICalendarServices, CalendarServices>();
            services.AddScoped<CalendarMapper>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            serviceProvider.GetService<CalendarDBContextDatabase>().Database.Migrate();
        }
    }
}
