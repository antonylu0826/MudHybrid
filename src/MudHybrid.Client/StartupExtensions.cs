using MudBlazor.Services;
using MudHybrid.Client.Services;
using MudHybrid.Shared.Services;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection
{
    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
    public static class StartupExtensions
    {
        public static IServiceCollection AddMudHybridServices(this IServiceCollection services)
        {
            services.AddMudServices();

            services.AddLocalization();

            //DI JwtIdentityService
            services.AddScoped<MudHybrid.Shared.Services.ISecureStorage, SecureStorageService>();
            services.AddSingleton<IPlatformFactor, PlatformFactor>();
            services.AddSingleton<IPreferencesFactor, PreferencesFactor>();

            //Must add this line for Authorization
            services.AddAuthorizationCore();

            return services;
        }
    }
}