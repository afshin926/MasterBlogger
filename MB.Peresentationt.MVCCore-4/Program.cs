using MB.Application;
using MB.Appliction.Contracts.ArticleCategory;
using MB.Domin.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repoistory;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();

        builder.Services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

        builder.Services.AddDbContext<MasterBloggerContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MasterBlogger")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.v
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();

        app.UseEndpoints(endpoint =>
        {
            endpoint.MapDefaultControllerRoute();
        });
    }
}