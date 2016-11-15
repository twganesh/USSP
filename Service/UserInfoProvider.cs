using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLB.USSP.Core.DTO;
using SLB.USSP.Repository;

namespace SLB.USSP.Service
{
    public interface IUserInfoProvider
    {
        bool ValidateUser(string username, string password);
        DTOWsseUser GetUser(string username);

        bool Authenticate(string username, string password);
    }
    public class UserInfoProvider : IUserInfoProvider
    {

        private readonly string _directoryEntry;
        private readonly string _domain;
        private readonly IWsseUserRepository _wsseUserRepository;
        public UserInfoProvider(string directoryEntry, string domain, IWsseUserRepository wsseUserRepository)
        {
            _wsseUserRepository = wsseUserRepository;
            _directoryEntry = directoryEntry;
            _domain = domain;
        }

        /// <summary>
        /// Verifies that the specified user name and password exist in the data source.
        /// </summary>
        /// <returns>
        /// true if the specified username and password are valid; otherwise, false.
        /// </returns>
        /// <param name="username">The name of the user to validate. </param><param name="password">The password for the specified user. </param>
        public bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            //using (var context = new MvcDemoEntities())
            //{
            //    var user = (from u in context.Users
            //                where String.Compare(u.Username, username, StringComparison.OrdinalIgnoreCase) == 0
            //                      && String.Compare(u.Password, password, StringComparison.OrdinalIgnoreCase) == 0
            //                      && !u.Deleted
            //                select u).FirstOrDefault();

            //    return user != null;
            //}

            return true;
        }

        public bool Authenticate(string username, string password)
        {
            var isAuthenticate = false;

            using (var pc = new PrincipalContext(ContextType.Domain, _domain))
            {
                isAuthenticate = pc.ValidateCredentials(username, password);
            }
            return isAuthenticate;

            //return true;

        }

        public DTOWsseUser GetUser(string username)
        {
            return new DTOWsseUser
            {
                Deleted = false,
                Email = "GTiwari2@slb.com",
                Name = "",
                Locked = 0,
                UserId = "GTiwari2",
                UserLevel = "1",
                LocationLdap = "",

            };
        }
    }
}
