using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks; /*El espacio de nombres System.Threading.Tasks proporciona clases y interfaces para el desarrollo de aplicaciones asíncronas
                               * . Las aplicaciones asíncronas son aplicaciones que pueden realizar varias tareas al mismo tiempo.*/

namespace Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices (this IServiceCollection services) /*La clase IServiceCollection representa una colección de servicios que se pueden inyectar en las clases de una aplicación.*/
        {
            services.AddAutoMapper (Assembly.GetExecutingAssembly ());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;

        }

    }
}




/*El método AddAutoMapper() registra un IMapper en la colección de servicios. El IMapper se utiliza para mapear objetos de un tipo a otro.
 * el método ConfigureApplicationServices() registra un IMapper en la colección de servicios. 
 * Esto permite que las clases de la aplicación utilicen el IMapper para mapear objetos de un tipo a otro.*/