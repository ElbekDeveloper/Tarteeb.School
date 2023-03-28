using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using Tarteeb.School.Brokers.ApiBrokers;
using Tarteeb.School.Brokers.DateTimes;
using Tarteeb.School.Brokers.Loggings;
using Tarteeb.School.Services.Foundations.Users;
using Tarteeb.School.Services.Tickets;
using Tarteeb.School.Services.Views.TicketViews;
using Tarteeb.School.Services.Views.UserViews;

namespace Tarteeb.School
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages(options =>
                options.RootDirectory = "/Views/Pages"
            );
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddHttpClient();
            builder.Services.AddServerSideBlazor();
            AddBrokers(builder);
            AddServices(builder);
            AddViewServices(builder);

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }

        private static void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITicketService, TicketService>();
            builder.Services.AddTransient<IUserService, UserService>();
        }

        private static void AddViewServices(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ITicketViewService, TicketViewService>();
            builder.Services.AddTransient<IUserViewService, UserViewService>();
        }

        private static void AddBrokers(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IApiBroker, ApiBroker>();
            builder.Services.AddTransient<ILoggingBroker, LoggingBroker>();
            builder.Services.AddTransient<IDateTimeBroker, DateTimeBroker>();
        }
    }
}