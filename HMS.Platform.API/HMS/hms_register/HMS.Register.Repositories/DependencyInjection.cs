using HMS.Register.Repositories.Interface;
using HMS.Register.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HMSDbContext>(options =>
               options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DBConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRegisterRepository, RegisterRepository>();
            services.AddScoped<ISignupRepository, SignupRepository>();
            return services;
        }
    }
}
