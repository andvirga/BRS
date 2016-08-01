using BRS.Data.Context;
using BRS.Data.Interfaces;
using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
//using Unity.Mvc5;
//using Unity.WebAPI;

namespace BRS.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IBRSContext, BRSContext>();

            // set MVC container.
            //DependencyResolver.SetResolver(new Microsoft.Practices.Unity.Mvc5.UnityDependencyResolver(container));
            // set Web.api container.
            //GlobalConfiguration.Configuration.DependencyResolver = new Microsoft.Practices.Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}