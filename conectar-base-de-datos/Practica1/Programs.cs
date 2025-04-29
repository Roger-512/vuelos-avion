var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();