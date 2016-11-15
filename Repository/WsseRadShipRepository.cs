
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseRadShipRepository : RepositoryBase<WsseRadShip>, IWsseRadShipRepository
    {
        public WsseRadShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}