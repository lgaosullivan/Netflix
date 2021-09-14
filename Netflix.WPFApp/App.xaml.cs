using Microsoft.Extensions.DependencyInjection;
using Netflix.WPF.Helpers;
using System.Windows;
using Netflix.WPFApp.Interfaces;
using Microsoft.Extensions.Configuration;
using System.IO;
using Netflix.WPFApp.Models;
using System;
using Microsoft.Extensions.Logging;

namespace Netflix.WPFApp
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //services.AddLogging(configure => configure.AddConsole());

            services.Configure<AppSettings>
        (Configuration.GetSection(nameof(AppSettings)));

            services.AddScoped<IMapping, Mapping>();
            services.AddScoped<IClient, Client>();


            services.AddTransient(typeof(Client));

            services.AddTransient(typeof(MainWindow));
        }
    }
}
