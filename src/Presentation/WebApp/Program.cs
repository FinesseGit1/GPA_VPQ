using Microsoft.Extensions.Options;
using WebApp.Models.AppSettings;
using WebApp.Services;
using WebApp.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<BackendAPIOptions>(builder.Configuration.GetSection(BackendAPIOptions.BackendAPI));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserMgmtService, UserMgmtService>();
builder.Services.AddScoped<ITestService, TestService>();
builder.Services.AddScoped<IVendorInvitationFormService, VendorInvitationFormService>();
builder.Services.AddHttpClient<BackendAPIService>(
    (service, client) =>
    {
        var options = service.GetRequiredService<IOptions<BackendAPIOptions>>();
        // Set the base address of the typed client.
        client.BaseAddress = options.Value.URIPath;
    });



// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
