using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WorkingWithEFCore;
using System.Collections.Generic;
using PacktLibrary;

namespace AdhocReading.Tests.DatabaseTests
{
    public static class Extensions
    {
        public static IServiceCollection AddInMemoryDatabase(this IServiceCollection services)
        => services.AddSingleton(sp =>
                new DbContextOptionsBuilder<NorthwindContext>()
        .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options)
            .AddSingleton<NorthwindContext>();
    }
    public class DatabaseTestBase
    {
        protected IServiceProvider? ServiceProvider;
        protected NorthwindContext? NorthwindContext;

        protected readonly Dictionary<string, object[]> _testData = new()
        {
            { 
                nameof(Category), 
                new object[] { new Category { CategoryId = 1 } } 
            }
        };
            
        [TestInitialize]
        public void SetUp()
        {
            var services = new ServiceCollection();

            ServiceProvider = services
                .AddInMemoryDatabase()
                .AddSingleton(_testData)
                .AddSingleton<TestDatabaseContainer>()
                .BuildServiceProvider();

            ServiceProvider.GetRequiredService<TestDatabaseContainer>().Go();
            NorthwindContext = ServiceProvider.GetRequiredService<NorthwindContext>();
        }

        [TestCleanup]
        public void Cleanup()
        {
            ServiceProvider.GetRequiredService<NorthwindContext>().Dispose();
        }
    }
}