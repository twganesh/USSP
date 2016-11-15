using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SLB.USSP.Repository;
using SLB.USSP.Service;

namespace SLB.USSP.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            string Conn = System.Configuration.ConfigurationManager.ConnectionStrings["WERCS"].ConnectionString;

            // register all your components with the container here
            // it is NOT necessary to register your controllers


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

            ControllerBuilder.Current.SetControllerFactory(new UnityControllerFactory(container));
        }
    }
}