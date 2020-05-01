
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RegisteredUsers.Infrastructure.Dependency
{
    public static class DependencyCoontainer
    {
        public static void BindDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataAccess.Sql.Core.RepositoryContexts>(options => options.UseSqlServer(configuration["ConnectionString:Registraion"]));
            services.AddScoped<Domain.Abstract.Repository.Entity.User.IUserRepository, RegisteredUsers.DataAccess.Sql.Core.UserRepository>();
            services.AddScoped<RegisteredUsers.Domain.Abstract.Service.Entity.IUserService, RegisteredUsers.Domain.Service.Entity.UserService>();
        }

        public static void BindUserApiDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Domain.Abstract.Repository.Document.IUserDocumentRepository, DataAccess.Mongo.Repository.UserDocumentRepository>();
            services.AddScoped<Domain.Abstract.Service.Document.IUserService, Domain.Service.Document.UserService>();
            BindDocumentDependency(services, configuration);
        }

        public static void BindDocumentDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DataAccess.Mongo.Core.Settings>(
                options =>
                {
                    options.ConnectionString = configuration.GetSection("MongoDb:ConnectionString").Value;
                    options.Database = configuration.GetSection("MongoDb:Database").Value;
                });
        }
    }
}
