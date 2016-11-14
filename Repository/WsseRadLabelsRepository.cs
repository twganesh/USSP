using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseRadLabelsRepository : RepositoryBase<WsseRadLabels>, IWsseRadLabelsRepository
    {
        public WsseRadLabelsRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}