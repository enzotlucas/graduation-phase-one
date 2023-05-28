﻿using FluentValidation;
using PoliceDepartment.EvidenceManager.Application.Authorization;
using PoliceDepartment.EvidenceManager.Application.Authorization.UseCases;
using PoliceDepartment.EvidenceManager.Application.Officer;
using PoliceDepartment.EvidenceManager.Application.Officer.UseCases;
using PoliceDepartment.EvidenceManager.Domain.Authorization;
using PoliceDepartment.EvidenceManager.Domain.Authorization.UseCases;
using PoliceDepartment.EvidenceManager.Domain.Officer.UseCases;
using PoliceDepartment.EvidenceManager.SharedKernel.Responses;
using PoliceDepartment.EvidenceManager.SharedKernel.ViewModels;
using System.Diagnostics.CodeAnalysis;

namespace PoliceDepartment.EvidenceManager.API.DependencyInjection.BusinessRules
{
    [ExcludeFromCodeCoverage]
    internal static class ApplicationExtensions
    {
        internal static IServiceCollection AddApplicationConfiguration(this IServiceCollection services)
        {
            services.AddScoped<ILogin<LoginViewModel, BaseResponseWithValue<AccessTokenModel>>, Login>();
            services.AddScoped<ICreateOfficer<CreateOfficerViewModel, BaseResponse>, Officer>();

            services.AddScoped<IValidator<CreateOfficerViewModel>, OfficerValidator>();

            services.AddAutoMapper(typeof(OfficerMapperProfile));

            return services;
        }
    }
}
