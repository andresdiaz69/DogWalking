namespace ECI.DogWalking
{
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using ECI.DataRepository.Context;
    using ECI.BusinessContracts.IServices;
    using ECI.BusinessServices.Services;
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.IRepository;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
            
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                        .ConfigureServices(services =>
                        {
                            services.AddDbContext<AppDbContext>(options =>
                                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ECI_DogWalks;Trusted_Connection=True;"));

                            // Services
                            services.AddScoped<ILoginService, LoginService>();

                            // Repositories
                            services.AddScoped<ILoginRepository, LoginRepository>();

                            // Main Forms
                            services.AddScoped<LoginForm>();
                        })
                        .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var form = host.Services.GetRequiredService<LoginForm>();
            Application.Run(form);

        }
    }
}