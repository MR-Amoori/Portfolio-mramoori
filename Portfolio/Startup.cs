using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.Hosting;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Repositories;
using Portfolio.DataLayer.Sevices;
using WebMarkupMin.AspNetCore5;


namespace Portfolio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebMarkupMin()
                .AddHtmlMinification()
                .AddHttpCompression()
                .AddXmlMinification()
                .AddXhtmlMinification();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddScoped<IIndexRepository, IndexRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IPersonalRepository, PersonalRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();


            string connetcionString = Configuration.GetConnectionString("Production");

            services.AddDbContext<PortfolioContext>(options => options.UseSqlServer(connetcionString));

            #region Identity

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<PortfolioContext>()
                .AddDefaultTokenProviders();

            #endregion

            services.AddAuthorization(options =>
                options.AddPolicy("Admin", policy =>
                    policy.RequireClaim("AdminNumber"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseWebMarkupMin();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}