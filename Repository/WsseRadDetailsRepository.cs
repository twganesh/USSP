using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseRadDetailsRepository : RepositoryBase<WsseRadDetails>, IWsseRadDetailsRepository
    {
        public WsseRadDetailsRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}