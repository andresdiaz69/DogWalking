namespace ECI.DogWalking
{
    using ECI.BusinessContracts.IServices;
    using ECI.BusinessServices.Services;
    using ECI.DataContracts.IRepository;
    using ECI.DataRepository.Context;
    using ECI.DataRepository.IRepository;
    using ECI.DataRepository.Repository;
    using ECI.DogWalking.Forms.Admin;
    using ECI.DogWalking.Forms.Shared.Menu;
    using ECI.DogWalking.Forms.Walks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

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
                                options.UseSqlServer("Server=MIPCHP;Database=ECI_DogWalks;Trusted_Connection=True;TrustServerCertificate=True;"));
                            //services.AddDbContext<AppDbContext>(options =>
                            //    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ECI_DogWalks;Trusted_Connection=True;"));

                            // Services
                            services.AddScoped<ILoginService, LoginService>();
                            services.AddScoped<IBreedService, BreedService>();
                            services.AddScoped<IDogService, DogService>();
                            services.AddScoped<IClientService, ClientService>();
                            services.AddScoped<IWalkService, WalkService>();

                            // Repositories
                            services.AddScoped<ILoginRepository, LoginRepository>();
                            services.AddScoped<IBreedRepository, BreedRepository>();
                            services.AddScoped<IDogRepostory, DogRepository>();
                            services.AddScoped<IClientRepository, ClientRepository>();
                            services.AddScoped<IWalkRepository, WalkRepository>();

                            // Main Forms
                            services.AddScoped<LoginForm>();
                            services.AddScoped<ClientsForm>();
                            services.AddScoped<DogsForm>();
                            services.AddScoped<WalksForm>();

                            // Menus
                            services.AddSingleton<IFormNavigator, FormNavigator>();

                        })
                        .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var loginForm = host.Services.GetRequiredService<LoginForm>();
            Application.Run(loginForm);

        }
    }
}