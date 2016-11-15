using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SLB.USSP.Core;

namespace SLB.USSP.Service
{
    public interface ICacheProvider
    {
        DateTime LastResetTime { get; }

        Dictionary<string, object> Keys { get; }

        object Remove(string key);

        IDictionary<string, object> RemoveMany(string keyPrefix);

        IDictionary<string, object> RemoveAll();

        object GetOrAddToCache(string key, Func<object> func);
    }


    public class CacheProvider : ICacheProvider
    {
        public Dictionary<string, object> Keys { get; private set; }

        private int _duration;
        private DateTime _lastResetTime;
        private object _keyLock;
        private const string NULL_OBJECT = "Dummy";

        public CacheProvider(int duration)
        {
            Keys = new Dictionary<string, object>();
            _keyLock = new object();
            _lastResetTime = DateTime.Now;
            _duration = duration;
        }

        public DateTime LastResetTime
        {
            get { return _lastResetTime; }
        }

        public object Remove(string key)
        {
            if (Keys.Keys.Any(k => k == key))
            {
                lock (_keyLock)
                {
                    try
                    {
                        if (Keys.Keys.Any(k => k == key))
                        {
                            //var obj = Keys[key];
                            //Keys.Remove(key);
                            //return obj;
                            Keys.Remove(key);
                            return HttpRuntime.Cache.Remove(key);
                        }
                    }
                    catch (Exception ex)
                    {
                        //_logger.LogException(GetType().Name, "Function: Remove({0})".FormatString(key), ex);
                    }
                }
            }

            return null;//item has been removed while waiting for a lock
        }

        public IDictionary<string, object> RemoveMany(string keyPrefix)
        {
            var dictionary = new Dictionary<string, object>();
            var keys = Keys.Where(k => k.Key.StartsWith(keyPrefix)).Select(k => k.Key);

            while (keys.Count() > 0)
            {
                var key = keys.First();
                dictionary.Add(key, Remove(key));
            }

            return dictionary;
        }

        public IDictionary<string, object> RemoveAll()
        {
            var dictionary = new Dictionary<string, object>();
            while (Keys.Count() > 0)
            {
                var key = Keys.First().Key;
                dictionary.Add(key, Remove(key));
            }

            _lastResetTime = DateTime.Now;

            return dictionary;
        }

        public object GetOrAddToCache(string key, Func<object> func)
        {
            //disable cache if cache duration is set to 0
            if (_duration == 0)
            {
                return func();
            }

            object result = null;

            if (!Keys.Keys.Any(k => k == key))
            {
                lock (_keyLock)
                {
                    try
                    {
                        if (!Keys.Keys.Any(k => k == key))
                            Keys.Add(key, NULL_OBJECT);
                    }
                    catch (Exception ex)
                    {
                        //_logger.LogException(GetType().Name, "Function: GetOrAddToCache({0})".FormatString(key), ex);
                    }
                }
            }
            var exclusiveKey = Keys[key];
            lock (exclusiveKey)
            {
                try
                {
                    result = HttpRuntime.Cache.Get(key);
                   
                    if (result == null)
                    {
                        result = func();
                        HttpRuntime.Cache.Insert(
                            key,
                            result,
                            null,
                            System.Web.Caching.Cache.NoAbsoluteExpiration,
                            TimeSpan.FromMinutes(_duration));
                        //Keys[key] = result;
                    }
                }
                catch (Exception ex)
                {
                    //_logger.LogException(GetType().Name, "Function: GetOrAddToCache({0})".FormatString(key), ex);
                    return null;
                }
            }

            return result;
        }
    }
}
