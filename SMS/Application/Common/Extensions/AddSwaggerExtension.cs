using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Extensions
{
    public static class AddSwaggerExtension 
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            // Register the Swagger services
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "School Management System API";
                    document.Info.Description = "A union solution to school management system.";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Siddhiganesh Joshi",
                        Email = "er.siddhartha1998@gmail.com",
                        Url = "siddhiganeshjoshi.com.np"
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license"
                    };
                };
            });
            return services;
        }
    }
}
