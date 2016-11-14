using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseRadConfigRepository : RepositoryBase<WsseRadConfig>, IWsseRadConfigRepository
    {
        public WsseRadConfigRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}