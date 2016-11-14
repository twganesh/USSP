using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseRadShipRepository : RepositoryBase<WsseRadShip>, IWsseRadShipRepository
    {
        public WsseRadShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}