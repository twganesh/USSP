using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseUserRepository : RepositoryBase<WsseUser>, IWsseUserRepository
    {
        public WsseUserRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}