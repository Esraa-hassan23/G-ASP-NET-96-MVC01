using Microsoft.AspNetCore.Routing.Constraints;
using MVC01.MiddleWares;

namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //register to Custom middleware

            app.UseMiddleware<TimeRequestMiddleWare>();



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseAuthentication();

            app.MapStaticAssets();

            
            //app.MapControllerRoute(
            //    name: "order",
            //    pattern: "{order}/{orderItem}/{id}",
            //    defaults: new
            //    {
            //        controller = "home",
            //        action = "index",
            //    },
            //    constraints: new
            //    {
            //        id = new IntRouteConstraint()
            //    }

            //    );


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
