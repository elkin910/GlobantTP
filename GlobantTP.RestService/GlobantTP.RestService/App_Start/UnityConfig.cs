using GlobantTP.RestService.Persistance.Repositories;
using GlobantTP.RestService.Repositories;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace GlobantTP.RestService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IPresidentRepository, PresidentRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}