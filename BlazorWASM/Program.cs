using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWASM;
using BlazorWASM.Auth;
using BlazorWASM.Services;
using HttpClients.ClientInterfaces;
using HttpClients.Implementations;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Auth;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IUserService, UserHttpClient>();
builder.Services.AddScoped<IBackLogService, BacklogHttpClient>();


builder.Services.AddScoped<IAuthService, JwtAuthService>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthProvider>();
AuthorizationPolicies.AddPolicies(builder.Services);

builder.Services.AddScoped(
    sp => 
        new HttpClient { 
            BaseAddress = new Uri("https://localhost:7038") 
        }
);


await builder.Build().RunAsync();