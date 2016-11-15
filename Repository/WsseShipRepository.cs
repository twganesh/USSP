
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SLB.USSP.Core.Models;

namespace SLB.USSP.Repository
{
    public class WsseShipRepository: RepositoryBase<WsseShip>, IWsseShipRepository
    {
        public WsseShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}