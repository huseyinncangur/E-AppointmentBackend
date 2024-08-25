

using Microsoft.Extensions.DependencyInjection;

namespace eAppointment.Application
{
    public class DependencyInjection
    {
        public static IServiceCollection AddApplication(IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
            return services;
        }
    }
}
