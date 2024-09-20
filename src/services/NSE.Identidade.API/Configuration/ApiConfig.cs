namespace NSE.Identidade.API.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this WebApplication app)
        {            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityConfiguration();

            app.MapControllers();

            app.Run();

            return app;
        }
    }
}
