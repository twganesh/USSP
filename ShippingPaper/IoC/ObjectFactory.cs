using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace SLB.USSP.Web.IoC
{
    public interface IObjectFactory
    {
        T GetObject<T>();
    }

    public class ObjectFactory : IObjectFactory
    {
        private IUnityContainer _container;

        public ObjectFactory(IUnityContainer container)
        {
            _container = container;
        }

        public T GetObject<T>()
        {
            var obj = _container.Resolve(typeof(T), null);

            if (obj == null)
                return default(T);
            return (T)obj;
        }
    }
}