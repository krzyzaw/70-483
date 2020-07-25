using System;
using System.IO;
using DataAccess.ConsumeData;
using DataAccess.Http;
using DataAccess.Linq;
using DataAccess.ObjectSerialization;
using DataAccess.SqlClient;
using DataAccess.Streams;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Data;

namespace DataAccess
{
    class Program
    {
        public static IConfigurationRoot configuration;

        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            LinqData test = new LinqData((MusicStoreContext)serviceProvider.GetService(typeof(MusicStoreContext)));
            test.ReadData();

            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddLogging();

            // Build configuration
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            // Add access to generic IConfigurationRoot
            serviceCollection.AddSingleton<IConfigurationRoot>(configuration);

            serviceCollection.AddDbContext<MusicStoreContext>(options =>
                options.UseSqlServer("Data Source=localhost,1433;Initial Catalog=MusicStore;User ID=SA;Password=szkolenie_483"));

            serviceCollection.AddTransient<MusicStoreContext>();
            serviceCollection.AddTransient<LinqData>();
        }
    }
}
