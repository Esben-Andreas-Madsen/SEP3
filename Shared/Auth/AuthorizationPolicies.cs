using Microsoft.Extensions.DependencyInjection;

namespace Shared.Auth;

public class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("MustBeScrumMaster", a =>
                a.RequireAuthenticatedUser().RequireClaim("Role", "Scrum Master"));
        });
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("MustBeProductOwner", a =>
                a.RequireAuthenticatedUser().RequireClaim("Role", "Product Owner"));
        });
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("MustBeScrumMember", a =>
                a.RequireAuthenticatedUser().RequireClaim("Role", "Scrum Member", "Scrum Master"));
        });
    }
}