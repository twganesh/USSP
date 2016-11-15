
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseRadConfigRepository : RepositoryBase<WsseRadConfig>, IWsseRadConfigRepository
    {
        public WsseRadConfigRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}