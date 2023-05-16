using A4___Movie_Library_Assignment.Services;
using Microsoft.Extensions.DependencyInjection;

namespace A4___Movie_Library_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var startup = new Startup();
            var ServiceProvider = startup.ConfigureServices();

            var service = ServiceProvider.GetService<IMainService>();

            //IMainService mainService = new MainService();
            service?.Invoke();

        }
    
    }
}
