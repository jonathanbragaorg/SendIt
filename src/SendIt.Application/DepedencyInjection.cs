using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SendIt.Application.Common.Behaviours;
using System.Reflection;

namespace SendIt.Application
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Pipelines
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>)); //#1

            return services;
        }
    }
}
