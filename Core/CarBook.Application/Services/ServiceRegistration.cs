using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarBook.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services, IConfiguration configration)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
        }
    }
}
