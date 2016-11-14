using Microsoft.Practices.Unity;
using USSP.Models.CORE;
using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Routing;

namespace USSP
{
    public class UnityControllerFactory : DefaultControllerFactory, IDisposable
    {
        private readonly IUnityContainer _container;

        public UnityControllerFactory(IUnityContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            try
            {                
                if (controllerType == null)
                    throw new ArgumentNullException("controllerType cannot be null", "controllerType");

                //always register the iidentity again for each user request so that the system will always has the latest user information
                var contextLifetimeMgrid = new HttpContextLifetimeManager<IIdentity>();                
                _container.RegisterInstance<IIdentity>(requestContext.HttpContext.User.Identity, contextLifetimeMgrid);

                //always register the cache
                var contextLifetimeMgr = new HttpContextLifetimeManager<Cache>();                
                _container.RegisterInstance<Cache>(requestContext.HttpContext.Cache, contextLifetimeMgr);

                return _container.Resolve(controllerType, new DependencyOverride<HttpContextBase>(requestContext.HttpContext)) as IController;
            }            
            catch (Exception ex)
            {
                Trace.WriteLine("Unhandled Exception: " + ex.ToString(), "Error");
                throw;
            }
        }

        public void Dispose()
        {
            //_container.Dispose();
        }
    }
}