
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseRadLabelsRepository : RepositoryBase<WsseRadLabels>, IWsseRadLabelsRepository
    {
        public WsseRadLabelsRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}