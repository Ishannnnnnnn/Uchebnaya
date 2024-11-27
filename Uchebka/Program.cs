using Application.Interfaces;
using Application.Mapping;
using Application.Services;
using AutoMapper;
using Infrastructure.Dal;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Uchebka
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
            
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = configurationBuilder.Build();
            
            ConfigureServices(serviceCollection, configuration);
            
            using var serviceProvider = serviceCollection.BuildServiceProvider();
            using var scope = serviceProvider.CreateScope();
            
            var userService = scope.ServiceProvider.GetRequiredService<UserService>();

            CancellationToken cancellationToken = new CancellationToken();
            
            System.Windows.Forms.Application.Run(new Form1(
                userService,
                cancellationToken));
        }
        
        private static void ConfigureServices(ServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            
            services.AddDbContext<UchebkaDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=Uchebka;Username=postgres;Password=7733"),
                ServiceLifetime.Transient);

            services.AddAutoMapper(typeof(UserMappingProfile));
            
            services.AddTransient<IUserRepository, UserRepository>();
            
            services.AddTransient<UserService>();
            services.AddTransient<UserService>(provider =>
            {
                var userRepository = provider.GetRequiredService<IUserRepository>();
                var mapper = provider.GetRequiredService<IMapper>();
                return new UserService(userRepository, mapper);
            });
        }
    }
}