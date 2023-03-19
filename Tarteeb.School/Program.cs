using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tarteeb.School.Brokers.ApiBrokers;
using Tarteeb.School.Services.Tickets;

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

            builder.Services.AddHttpClient();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddTransient<IApiBroker, ApiBroker>();
            builder.Services.AddTransient<ITicketService, TicketService>();

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
    }
}