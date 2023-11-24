using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using dotnetdocker.Models; // Assuming your models are in a 'Model' namespace

namespace dotnetdocker
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
