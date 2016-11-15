
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseUserRepository : RepositoryBase<WsseUser>, IWsseUserRepository
    {
        public WsseUserRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}