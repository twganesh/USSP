using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SLB.USSP.Core;
using SLB.USSP.Core.DTO;

namespace SLB.USSP.Service.Helper
{

    public interface IUserProfile
    {
       

        bool IsAuthorized { get; }
        

        DTOWsseUser Preferences { get; set; }

        void ExpireCache();

        void ExpireCache(string UserName);

        void Reload();

    }
    public class UserProfile : IUserProfile
    {
        public const string CACHE_KEY_USER_RESET = "RESETUSER_{0}";
        public const string CACHE_KEY_USER_PROFILE_PREFIX = "USERPROFILE_";
        public const string CACHE_KEY_USER_PREFERENCE_PREFIX = "PREFERENCES_";        
        public const string CACHE_KEY_LAST_RESET_TIME = "CACHE_KEY_LAST_RESET_TIME";

        

        public DTOWsseUser Preferences { get; set; }

        public bool IsAuthorized { get; private set; }

       
        private HttpContextBase _context;

        private ICacheProvider _cache;
        private IUserInfoProvider _provider;

        public UserProfile(HttpContextBase context, ICacheProvider cache, IUserInfoProvider provider)
        {
            _context = context;
            _cache = cache;
            _provider = provider;           
            InitializePreferences();
            InitializeTimeStamp();
        }

        private void InitializeTimeStamp()
        {
            var lastResetTime = _context.Session[CACHE_KEY_LAST_RESET_TIME] as DateTime?;
            if (lastResetTime == null ||
                (lastResetTime.HasValue && lastResetTime < _cache.LastResetTime))
            {
                _context.Session[CACHE_KEY_LAST_RESET_TIME] = DateTime.Now;
            }
        }

     
        private void InitializePreferences()
        {
            Preferences = new DTOWsseUser(); //set the default user preference first

            if (_context.User.Identity.IsAuthenticated)
            {
                var preferenceKey = CACHE_KEY_USER_PROFILE_PREFIX + CACHE_KEY_USER_PREFERENCE_PREFIX + _context.User.Identity.Name;
                var cachedUser = (DTOWsseUser)GetOrAddToSession(preferenceKey, () => _provider.GetUser(_context.User.Identity.Name));

                if (cachedUser != null)
                {
                    Preferences = cachedUser;
                }
            }
        }

       
        public void ExpireCache()
        {
            ExpireCache(_context.User.Identity.Name);
        }

        public void ExpireCache(string userName)
        {
            //set the cache as dirty
            var resetKey = CACHE_KEY_USER_RESET.FormatString(userName);
            _cache.Remove(resetKey);
            _cache.GetOrAddToCache(resetKey, () => DateTime.Now);
        }

        public void Reload()
        {
            InitializePreferences();
            InitializeTimeStamp();
        }

       

        private object GetOrAddToSession(string key, Func<object> func)
        {
            //cleaup cache if system instructs a reload
            var sessionLastResetTime = _context.Session[CACHE_KEY_LAST_RESET_TIME] as DateTime?;
            var systemLastResetTime = _cache.LastResetTime;

            //this value may be set in cache in the last ExpireCache call
            var userLastResetTime = (DateTime)_cache.GetOrAddToCache(CACHE_KEY_USER_RESET.FormatString(_context.User.Identity.Name), () => DateTime.Now);

            //clear session variables if 
            //1. the system requested a reset
            //2. the user profile requrested a reset
            if (sessionLastResetTime.HasValue)
            {
                if (sessionLastResetTime.Value < systemLastResetTime
                    || sessionLastResetTime.Value < userLastResetTime)
                {
                    _context.Session.RemoveAll();
                }
            }


            var cachedItem = _context.Session[key];
            if (cachedItem == null)
            {
                cachedItem = func();
                _context.Session[key] = cachedItem;
            }

            return cachedItem;
        }

        private object RemoveFromSession(string key)
        {
            var cachedItem = _context.Session[key];
            _context.Session.Remove(key);

            return cachedItem;
        }
    }
}
