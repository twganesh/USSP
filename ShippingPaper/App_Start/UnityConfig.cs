using System.Configuration;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SLB.USSP.Core;
using SLB.USSP.Repository;
using SLB.USSP.Service;
using SLB.USSP.Web.IoC;

namespace SLB.USSP.Web
{    
    public static class UnityConfig
    {
        static string Conn = System.Configuration.ConfigurationManager.ConnectionStrings["WERCS"].ConnectionString;

        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            #region Singleton Lifetime objects

            container.RegisterType<ICacheProvider, CacheProvider>(new ContainerControlledLifetimeManager(), new InjectionConstructor(240));
            container.RegisterObjectFactory();

            #endregion Singleton Lifetime objects




            container.RegisterType<GCRCContext, GCRCContext>(
                new HttpContextLifetimeManager<GCRCContext>(),
                new InjectionConstructor(
                    Conn,
                    "WERCS",
                   120)
                );

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HttpContextLifetimeManager<IUnitOfWork>());

            container.RegisterType<IDataContextFactory, DataContextFactory>(new HttpContextLifetimeManager<IDataContextFactory>());

            container.RegisterType(typeof(RepositoryBase<>), new InjectionConstructor(typeof(IDataContextFactory)));

            container.RegisterType<IPickListProvider, PickListProvider>(new HttpContextLifetimeManager<IPickListProvider>());
            container.RegisterType<ITMSShipmentProvider, TMSShipmentsProvider>(new HttpContextLifetimeManager<ITMSShipmentProvider>());

            container.RegisterType<IWsseUserRepository, WsseUserRepository>(new HttpContextLifetimeManager<IWsseUserRepository>());
            container.RegisterType<ITProdDataRepository, TProdDataRepository>(new HttpContextLifetimeManager<ITProdDataRepository>());
            container.RegisterType<IWsseDotShipRepository, WsseDotShipRepository>(new HttpContextLifetimeManager<IWsseDotShipRepository>());
            container.RegisterType<IWsseMatShipRepository, WsseMatShipRepository>(new HttpContextLifetimeManager<IWsseMatShipRepository>());
            container.RegisterType<IWsseRadConfigRepository, WsseRadConfigRepository>(new HttpContextLifetimeManager<IWsseRadConfigRepository>());
            container.RegisterType<IWsseRadDetailsRepository, WsseRadDetailsRepository>(new HttpContextLifetimeManager<IWsseRadDetailsRepository>());
            container.RegisterType<IWsseRadLabelsRepository, WsseRadLabelsRepository>(new HttpContextLifetimeManager<IWsseRadLabelsRepository>());
            container.RegisterType<IWsseRadShipRepository, WsseRadShipRepository>(new HttpContextLifetimeManager<IWsseRadShipRepository>());
            container.RegisterType<IWsseShipRepository, WsseShipRepository>(new HttpContextLifetimeManager<IWsseShipRepository>());
            container.RegisterType<IWsseTMSProductsRepository, WsseTMSProductsRepository>(new HttpContextLifetimeManager<IWsseTMSProductsRepository>());
            container.RegisterType<IWsseUserRepository, WsseUserRepository>(new HttpContextLifetimeManager<IWsseUserRepository>());
            container.RegisterType<IShippingPaperProvider, ShippingPaperProvider>(new HttpContextLifetimeManager<IShippingPaperProvider>());

            container.RegisterType<ICacheProvider, CacheProvider>(new HttpContextLifetimeManager<ICacheProvider>());

            container.RegisterType<IUserInfoProvider, UserInfoProvider>
         (
             new InjectionConstructor(ConfigurationManager.AppSettings["LDAPURL"], Constants.DOMAIN, typeof(IWsseUserRepository))
         );


            ControllerBuilder.Current.SetControllerFactory(new UnityControllerFactory(container));
        }

        private static IUnityContainer RegisterObjectFactory(this IUnityContainer container)
        {
            var subContainer = new UnityContainer();

            var cache = container.Resolve<ICacheProvider>();
            subContainer
                //.RegisterType<IIdentity, DefaultIdentity>()
                //.RegisterType<ILogger, SystemLogger>()               
                .RegisterType<IDataContextFactory, DataContextFactory>()
                .RegisterType<GCRCContext, GCRCContext>(new InjectionConstructor(Conn, "WERCS", 120))                
                .RegisterInstance<ICacheProvider>(cache);
            return container.RegisterInstance<IObjectFactory>(new ObjectFactory(subContainer), new ContainerControlledLifetimeManager());
        }
    }
}