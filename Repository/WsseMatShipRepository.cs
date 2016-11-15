
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseMatShipRepository : RepositoryBase<WsseMatShip>, IWsseMatShipRepository
    {
        public WsseMatShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}