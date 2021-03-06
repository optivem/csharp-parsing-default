﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Atomiv.Core.Application;
using Atomiv.DependencyInjection.Common;
using Atomiv.Infrastructure.FluentValidation;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Atomiv.DependencyInjection.Infrastructure.FluentValidation
{
    public static class ServiceCollectionExtensions
    {
        private static Type ValidatorType = typeof(IValidator<>);

        public static IServiceCollection AddFluentValidationInfrastructure(this IServiceCollection services, params Assembly[] assemblies)
        {

            services.AddScoped(typeof(IRequestValidator<>), typeof(FluentValidationRequestValidator<>));

            var types = assemblies.GetTypes();
            services.AddValidators(types);

            return services;
        }

        private static IServiceCollection AddValidators(this IServiceCollection services, IEnumerable<Type> types)
        {
            var implementationTypes = types.GetConcreteImplementationsOfGenericInterface(ValidatorType);
            services.AddScopedOpenType(ValidatorType, implementationTypes);

            return services;
        }
    }
}