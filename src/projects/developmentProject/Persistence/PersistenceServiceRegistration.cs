﻿
using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Persistence.Contexts;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("DevelopmentProjectConnectionString")));
            services.AddScoped<IProgramingLanguageRepository, ProgramingLanguageRepository>();
            services.AddScoped<IProgramingLanguageTechnologyRepository, ProgramingLanguageTechnologyRepository>();  
            return services;
        }
    }
}
