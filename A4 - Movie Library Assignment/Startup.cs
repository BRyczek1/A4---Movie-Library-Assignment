using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A4___Movie_Library_Assignment.Services;
using Microsoft.Extensions.DependencyInjection;

namespace A4___Movie_Library_Assignment
{
    public class Startup
    {
        public ServiceProvider ConfigureServices() 
        { 
            IServiceCollection services = new ServiceCollection();

            services.AddLogging();

            services.AddSingleton<IMainService, MainService>();


            return services.BuildServiceProvider();
        }


    }
}
