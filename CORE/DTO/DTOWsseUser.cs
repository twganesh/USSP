using System;
using System.Security.Principal;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseUser
    {
        public string UserId { get; set; }

        public string UserLevel { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public int Locked { get; set; }

        public string LocationLdap { get; set; }

        public DateTime TrainingComplete { get; set; }

        public DateTime LastLogin { get; set; }

        public bool Deleted { get; set; }

        public DateTime DeletedDate { get; set; }

        public string DeletedBy { get; set; }
    }

    /// <summary>
    /// An identity object represents the user on whose behalf the code is running.
    /// </summary>
    [Serializable]
    public class CustomIdentity : IIdentity
    {
        #region Properties

        public IIdentity Identity { get; set; }

        public DTOWsseUser User { get; set; }    

        public Enums.UserRole Role { get; set; }
       

        #endregion

        #region Implementation of IIdentity

        /// <summary>
        /// Gets the name of the current user.
        /// </summary>
        /// <returns>
        /// The name of the user on whose behalf the code is running.
        /// </returns>
        public string Name
        {
            get { return Identity.Name; }
        }

        /// <summary>
        /// Gets the type of authentication used.
        /// </summary>
        /// <returns>
        /// The type of authentication used to identify the user.
        /// </returns>
        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        /// <summary>
        /// Gets a value that indicates whether the user has been authenticated.
        /// </summary>
        /// <returns>
        /// true if the user was authenticated; otherwise, false.
        /// </returns>
        public bool IsAuthenticated { get { return Identity.IsAuthenticated; } }

        #endregion

        #region Constructor

        public CustomIdentity(IIdentity identity, DTOWsseUser user, Enums.UserRole role)
        {
            Identity = identity;
           
            if (user != null)
            {
                User = user;
                Role = role;
            }
        }

        #endregion
    }

    [Serializable]
    public class CustomPrincipal : IPrincipal
    {
        #region Implementation of IPrincipal

        /// <summary>
        /// Determines whether the current principal belongs to the specified role.
        /// </summary>
        /// <returns>
        /// true if the current principal is a member of the specified role; otherwise, false.
        /// </returns>
        /// <param name="role">The name of the role for which to check membership. </param>
        public bool IsInRole(string role)
        {
            return Identity is CustomIdentity &&
                   string.Compare(role, ((CustomIdentity)Identity).Role.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0;
        }

        /// <summary>
        /// Gets the identity of the current principal.
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Security.Principal.IIdentity"/> object associated with the current principal.
        /// </returns>
        public IIdentity Identity { get; private set; }

        #endregion

        public CustomIdentity CustomIdentity { get { return (CustomIdentity)Identity; } set { Identity = value; } }

        public CustomPrincipal(CustomIdentity identity)
        {
            Identity = identity;
        }
    }
}
