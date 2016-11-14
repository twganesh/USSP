using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using USSP.Repository;

namespace Repository
{
    public class WsseMatShipRepository : RepositoryBase<WsseMatShip>, IWsseMatShipRepository
    {
        public WsseMatShipRepository(IDataContextFactory contextFactory)
            :base(contextFactory)
        { }
    }
}