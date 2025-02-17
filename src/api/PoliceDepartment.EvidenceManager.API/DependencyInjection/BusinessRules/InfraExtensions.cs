﻿using Microsoft.EntityFrameworkCore;
using PoliceDepartment.EvidenceManager.Domain.Case;
using PoliceDepartment.EvidenceManager.Domain.Database;
using PoliceDepartment.EvidenceManager.Domain.Evidence;
using PoliceDepartment.EvidenceManager.Domain.Officer;
using PoliceDepartment.EvidenceManager.Infra.Database;
using PoliceDepartment.EvidenceManager.Infra.Database.Mappings;
using PoliceDepartment.EvidenceManager.Infra.Database.Repositories;
using PoliceDepartment.EvidenceManager.Infra.FileManager;
using PoliceDepartment.EvidenceManager.Infra.Identity;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace PoliceDepartment.EvidenceManager.API.DependencyInjection.BusinessRules
{
    [ExcludeFromCodeCoverage]
    internal static class InfraExtensions
    {
        internal static IServiceCollection AddInfraConfiguration(this IServiceCollection services, IConfiguration configuration, bool isDevelopment)
        {
            services.AddScoped<IAppDatabaseContext, SqlServerContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEvidenceRepository, EvidenceRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
            services.AddScoped<IOfficerRepository, OfficerRepository>();

            services.AddTransient(o => new SqlConnection(configuration.GetConnectionString("SqlServerConnection")));
            services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
            services.AddLogging();

            if (isDevelopment)
            {
                services.AddScoped<IEvidenceFileServer, EvidenceLocalServer>();
            }
            else
            {
                services.AddScoped<IEvidenceFileServer, EvidenceLocalServer>();
            }


            return services;
        }
    }
}
